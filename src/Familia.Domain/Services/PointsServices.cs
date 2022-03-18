using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Repositories;
using Familia.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Domain.Services
{
    public class PointsServices : IPointsServices
    {

        private readonly IFamilyRepositorie _familyRepositorie;

        public PointsServices(IFamilyRepositorie familyRepositorie)
        {
            _familyRepositorie = familyRepositorie;
        }

        public Task<IEnumerable<Points>> GetPointsFamily()
        {
            throw new NotImplementedException();
        }
    }
}
