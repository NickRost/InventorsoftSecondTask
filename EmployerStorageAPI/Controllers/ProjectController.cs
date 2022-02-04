using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
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
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;
        private readonly IMapper mapper;

        public ProjectController(IProjectService projectService, IMapper mapper)
        {
            this.projectService = projectService;
            this.mapper = mapper;
        }

        [HttpPost]
        public ActionResult<ProjectDto> CreateProject(ProjectDto item)
        {
            var mapped = mapper.Map<ProjectDto, Project>(item);
            projectService.Add(mapped);

            projectService.SaveChanges();

            return Ok(item);
        }

        [HttpDelete]
        public ActionResult DeleteProject(ProjectDto item)
        {
            var mapped = mapper.Map<ProjectDto, Project>(item);
            this.projectService.Remove(mapped);

            projectService.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public ActionResult<ProjectDto> GetProject(ProjectDto item)
        {
            var mapped = mapper.Map<ProjectDto, Project>(item);
            var result = this.projectService.Get(x => x.Id == mapped.Id);

            var mappedResult = mapper.Map<Project, ProjectDto>(result);

            return Ok(mappedResult);
        }
    }
}
