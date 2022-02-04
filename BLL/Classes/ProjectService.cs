using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class ProjectService : BaseService<Project>, IProjectService
    {
        private readonly EmployerContext context;
        public ProjectService(EmployerContext context) : base(context)
        {
        }
    }
}
