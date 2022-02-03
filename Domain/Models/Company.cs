using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CityId { get; set; }

        public virtual City City { get; set; }

        public virtual Office Office { get; set; }

        public ICollection<Employer> Employers { get; set; }
    }
}
