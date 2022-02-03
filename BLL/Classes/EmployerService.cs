using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using Domain;

namespace BLL.Classes
{
    public class EmployerService: BaseService<Employer>, IEmployerService
    {
        private readonly EmployerContext context;
        public EmployerService(EmployerContext context):base(context)
        {
        }
    }
}
