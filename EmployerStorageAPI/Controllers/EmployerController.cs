using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployerController: ControllerBase
    {
        private readonly IEmployerService employerService;
        public EmployerController(IEmployerService employerService)
        {
            this.employerService = employerService;
        }

        [HttpPost]
        public void CreateEmployer(Employer employer)
        {
            employerService.Add(employer);

            employerService.SaveChanges();
        }
    }
}
