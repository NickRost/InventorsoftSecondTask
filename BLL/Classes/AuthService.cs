using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Classes
{
    public class AuthService : IAuthService
    {
        private protected readonly EmployerContext _context;
        private protected readonly IMapper _mapper;
        private protected readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration, EmployerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<EmployerDto> Register(EmployerRegisterDto employer)
        {
            Employer newEmployer = _mapper.Map<Employer>(employer);

            Console.WriteLine("test");

            CreatePasswordHash(employer.Password, out byte[] passwordHash, out byte[] passwordSalt);

            newEmployer.PasswordHash = passwordHash;
            newEmployer.PasswordSalt = passwordSalt;

            _context.Employers.Add(newEmployer);
            await _context.SaveChangesAsync();

            return _mapper.Map<EmployerDto>(newEmployer);
        }

        public async Task<EmployerAuthDto> Login(EmployerLoginDto employer)
        {
            var employerEntity = await _context.Employers.FirstOrDefaultAsync(u => u.Email == employer.Email);

            if (employerEntity == null)
            {
                throw new Exception(nameof(employer));
            }

            if (!VerifyPasswordHash(employer.Password, employerEntity.PasswordHash, employerEntity.PasswordSalt))
            {
                throw new Exception("Wrong password");
            }

            EmployerAuthDto authDto = new EmployerAuthDto
            {
                User = _mapper.Map<EmployerDto>(employerEntity),
                AccessToken = CreateToken(employerEntity)
            };
            return authDto;
        }
    
        private string CreateToken(Employer user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

    }
}
