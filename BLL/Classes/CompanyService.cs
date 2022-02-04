using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class CompanyService : BaseService<Company>, ICompanyService
    {
        private readonly EmployerContext context;
        public CompanyService(EmployerContext context) : base(context)
        {
        }
    }
}
