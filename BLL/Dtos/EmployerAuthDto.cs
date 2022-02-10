using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dtos
{
    public class EmployerAuthDto
    {
        public EmployerDto User { get; set; }

        public string AccessToken { get; set; }
    }
}
