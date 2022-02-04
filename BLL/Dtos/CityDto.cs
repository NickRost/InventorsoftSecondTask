using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dtos
{
    public class CityDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PostalCode { get; set; }
    }
}
