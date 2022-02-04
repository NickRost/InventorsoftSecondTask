using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL.Classes
{
    public class TaskService : BaseService<Task>, ITaskService
    {
        private readonly EmployerContext context;
        public TaskService(EmployerContext context) : base(context)
        {


        }

        public IEnumerable<Task> GetFinishedTasks()
        {
            IEnumerable<Task> result = context.Set<Task>().Where(x => x.FinishedAt != null);
            return result;
        }
    }
}
