using Familia.Domain.Entities;
using System.Collections.Generic;

namespace Familia.Domain.Interfaces.Factory
{
    public interface IProviderPoints
    {
        public void GeneratePointsValues(IEnumerable<Family> families, List<Points> points);
    }
}
