using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain
{
    public class Employer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirstDate { get; set; }

        public Guid? CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<EmployerSkill> EmployerSkills { get; set; }
    }
}
