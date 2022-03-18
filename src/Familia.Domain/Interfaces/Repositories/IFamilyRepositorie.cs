using Familia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Domain.Interfaces.Repositories
{
    public interface IFamilyRepositorie
    {
        Task<IEnumerable<Family>> GeFamilia();
    }
}
