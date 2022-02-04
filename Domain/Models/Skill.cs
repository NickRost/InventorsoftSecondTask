using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Skill
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual IList<EmployerSkill> EmployerSkills { get; set; }
    }
}
