using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmployerService: IBaseService<Employer>
    {
        public Task<IEnumerable<Employer>> GetMany();
    }
}
