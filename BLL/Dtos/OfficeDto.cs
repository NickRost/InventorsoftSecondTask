using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dtos
{
    class OfficeDto
    {
        public Guid Id { get; set; }

        public string Adress { get; set; }

        public Guid? CompanyId { get; set; }

    }
}
