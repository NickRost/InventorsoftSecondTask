using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dtos
{
    public class EmployerDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime BirstDate { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? TeamId { get; set; }
    }
}
