using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployerStorageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;
        private readonly IMapper mapper;

        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            this.companyService = companyService;
            this.mapper = mapper;
        }

        [HttpPost]
        public ActionResult<CompanyDto> CreateCompany(CompanyDto employer)
        {
            var mapped = mapper.Map<CompanyDto, Company>(employer);
            companyService.Add(mapped);

            companyService.SaveChanges();

            return Ok(employer);
        }

        [HttpDelete]
        public ActionResult DeleteCompany(CompanyDto item)
        {
            var mapped = mapper.Map<CompanyDto, Company>(item);
            this.companyService.Remove(mapped);

            companyService.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public ActionResult<CompanyDto> GetCompany(CompanyDto item)
        {
            var mapped = mapper.Map<CompanyDto, Company>(item);
            var result = this.companyService.Get(x => x.Id == mapped.Id);

            var mappedResult = mapper.Map<CompanyDto, Company>(item);

            return Ok(mappedResult);
        }

    }
}
