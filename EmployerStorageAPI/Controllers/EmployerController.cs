﻿using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployerStorageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployerController: ControllerBase
    {
        private readonly IEmployerService employerService;
        private readonly IMapper mapper;

        public EmployerController(IEmployerService employerService, IMapper mapper)
        {
            this.employerService = employerService;
            this.mapper = mapper;
        }

        [HttpPost]
        public ActionResult<EmployerDto> CreateEmployer(EmployerDto employer)
        {
            var mapped = mapper.Map<EmployerDto, Employer>(employer);
            employerService.Add(mapped);

            employerService.SaveChanges();

            return Ok(employer);
        }

        [HttpDelete]
        public ActionResult DeleteEmployer(EmployerDto item)
        {
            var mapped = mapper.Map<EmployerDto, Employer>(item);
            this.employerService.Remove(mapped);

            employerService.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public ActionResult<EmployerDto> GetEmployer(EmployerDto item)
        {
            var mapped = mapper.Map<EmployerDto, Employer>(item);
            var result = this.employerService.Get(x => x.Id == mapped.Id);

            var mappedResult = mapper.Map<Employer, EmployerDto>(result);

            return Ok(mappedResult);
        }

        [HttpGet("all")]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<IEnumerable<EmployerDto>>> GetEmployers()
        {

            var result = await this.employerService.GetMany();

            var mappedResult = mapper.Map<IEnumerable<EmployerDto>>(result);

            return Ok(mappedResult);
        }
    }
}
