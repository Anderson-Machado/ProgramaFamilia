using Familia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familia.Domain.Interfaces.Factory
{
    public interface IProviderPoints
    {
        public void GeneratePointsValues(IEnumerable<Family> families, List<Points> points);
    }
}
