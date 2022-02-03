using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dtos
{
    public class CompanyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CityId { get; set; }

    }
}
