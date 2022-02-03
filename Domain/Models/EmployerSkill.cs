using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class EmployerSkill
    {
        public Guid EmployerId { get; set; }

        public virtual Employer Employer { get; set; }

        public Guid SkillId { get; set; }

        public Skill Skill { get; set; }
    }
}
