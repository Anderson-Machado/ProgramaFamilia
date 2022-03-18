using Familia.Application.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Application.Interfaces
{
    public interface IPointsAppServices
    {
        Task<IEnumerable<PointsViewModel>> GetPointsFamily();
    }
}
