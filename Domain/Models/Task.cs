using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Task
    {
        public Guid Id { get; set; }


        public int ProjectId { get; set; }
        public Project Project { get; set; }


        public int? PerformerId { get; set; }
        public Employer Performer { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? FinishedAt { get; set; }
    }
}
