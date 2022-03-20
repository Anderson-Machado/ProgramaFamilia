using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Factory;
using Familia.Domain.Interfaces.Repositories;
using Familia.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familia.Domain.Services
{
    public class PointsServices : IPointsServices
    {

        private readonly IFamilyRepositorie _familyRepositorie;
        private readonly IProviderPoints _providerPoints;

        public PointsServices(IFamilyRepositorie familyRepositorie, IProviderPoints providerPoints)
        {
            _familyRepositorie = familyRepositorie;
            _providerPoints = providerPoints;
        }

        public async Task<IEnumerable<Points>> GetPointsFamily()
        {

            var family = await _familyRepositorie.GeFamilia();

            var listPoints = new List<Familia.Domain.Entities.Points>();

            _providerPoints.GeneratePointsValues(family, listPoints);

            return listPoints.OrderByDescending(x => x.PointsFamily);
        }
    }
}
