using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.Dtos;
using BLL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace BLL.Classes
{
    public class EmployerService: BaseService<Employer>, IEmployerService
    {
        public EmployerService(EmployerContext context):base(context)
        {

        }

        public async Task<IEnumerable<Employer>> GetMany()
        {
            return await context.Employers.ToListAsync();
        }
    }
}
