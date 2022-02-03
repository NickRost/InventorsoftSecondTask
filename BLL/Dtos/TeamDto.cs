using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class TeamDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
