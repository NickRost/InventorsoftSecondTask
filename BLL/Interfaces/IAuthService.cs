using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAuthService
    {
        public Task<EmployerDto> Register(EmployerRegisterDto employer);

        public Task<EmployerAuthDto> Login(EmployerLoginDto employer);
    }
}
