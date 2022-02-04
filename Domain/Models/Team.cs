using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Team
    {
        public Guid Id { get; set; }


        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Employer> Employers { get; set; }
    }
}
