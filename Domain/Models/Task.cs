using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Task
    {
        public Guid Id { get; set; }


        public Guid? ProjectId { get; set; }
        public virtual Project Project { get; set; }


        public Guid? PerformerId { get; set; }
        public virtual Employer Performer { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? FinishedAt { get; set; }
    }
}
