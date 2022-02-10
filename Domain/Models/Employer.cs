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

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Role { get; set; }

        public DateTime BirstDate { get; set; }

        public Guid? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public Guid? TeamId { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<EmployerSkill> EmployerSkills { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
