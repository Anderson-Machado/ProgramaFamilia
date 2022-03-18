using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Repositories;
using Familia.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Points>> GetPointsFamily()
        {
           //TODO: AJUSTAR CODIGO PARA EFETUAR OS DEVIDOS CALCULOS AQUI.

            var listPoints = new List<Points>() { new Points() { Id = 1, Name = "papa", PointsFamily = 5 } };

            return listPoints;
        }
    }
}
