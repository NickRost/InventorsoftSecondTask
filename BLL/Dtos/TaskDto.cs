using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class TaskDto
    {
        public Guid? Id { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? PerformerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
    }
}
