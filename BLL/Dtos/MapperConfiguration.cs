using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dtos
{
    public class MapperConfiguration
    {
        public AutoMapper.MapperConfiguration Configure()
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityDto>().ReverseMap();
                cfg.CreateMap<Company, CompanyDto>().ReverseMap();
                cfg.CreateMap<Employer, EmployerDto>().ReverseMap();
                cfg.CreateMap<EmployerSkill, EmployerSkillDto>().ReverseMap();
                cfg.CreateMap<Skill, SkillDto>().ReverseMap();
                cfg.CreateMap<Project, ProjectDto>().ReverseMap();
                cfg.CreateMap<Team, TeamDto>().ReverseMap();
                cfg.CreateMap<Task, TaskDto>().ReverseMap();
                cfg.CreateMap<EmployerRegisterDto, Employer>().ReverseMap();

            });
            return config;
        }
    }
}
