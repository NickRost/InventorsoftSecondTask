using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Project
    {
        public Guid Id { get; set; }

        
        public Guid? AuthorId { get; set; }
        public virtual Employer Author { get; set; }

        public Guid? TeamId { get; set; }
        public virtual Team Team { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
