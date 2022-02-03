using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class ProjectDto
    {
        public Guid? Id { get; set; }
        public Guid? AuthorId { get; set; }
        public Guid? TeamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
