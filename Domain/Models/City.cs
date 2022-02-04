using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class City
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PostalCode { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
