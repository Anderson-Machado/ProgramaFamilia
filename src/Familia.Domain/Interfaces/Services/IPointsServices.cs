using Familia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Domain.Interfaces.Services
{
    public interface IPointsServices
    {
        Task<IEnumerable<Points>> GetPointsFamily();
    }
}
