using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Domain.Interfaces.Services
{
    public interface IPointsServices
    {
        Task<IEnumerable<Familia.Domain.Entities.Points>> GetPointsFamily();
    }
}
