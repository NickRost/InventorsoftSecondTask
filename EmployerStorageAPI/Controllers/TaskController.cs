using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace EmployerStorageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;
        private readonly IMapper mapper;

        public TaskController(ITaskService taskService, IMapper mapper)
        {
            this.taskService = taskService;
            this.mapper = mapper;
        }

        [HttpPost]
        public ActionResult<TaskDto> CreateTask(TaskDto item)
        {
            var mapped = mapper.Map<TaskDto, Domain.Models.Task>(item);
            taskService.Add(mapped);

            taskService.SaveChanges();

            return Ok(item);
        }

        [HttpDelete]
        public ActionResult DeleteTask(TaskDto item)
        {
            var mapped = mapper.Map<TaskDto, Domain.Models.Task>(item);
            this.taskService.Remove(mapped);

            taskService.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public ActionResult<TaskDto> GetTask(TaskDto item)
        {
            var mapped = mapper.Map<TaskDto, Domain.Models.Task>(item);
            var result = this.taskService.Get(x => x.Id == mapped.Id);

            var mappedResult = mapper.Map<Domain.Models.Task, TaskDto>(result);

            return Ok(mappedResult);
        }

        [HttpGet("finished")]
        public ActionResult<IEnumerable<TaskDto>> GetFinishedTasks()
        {

            return Ok(mapper.Map<IEnumerable<Domain.Models.Task>, IEnumerable<TaskDto>>(taskService.GetFinishedTasks()));
        }

    }
}
