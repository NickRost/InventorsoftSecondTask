using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Office
    {
        public Guid Id { get; set; }

        public string Adress { get; set; }

        public Guid? CompanyId { get; set; }

        public Company Company { get; set; }

    }
}
