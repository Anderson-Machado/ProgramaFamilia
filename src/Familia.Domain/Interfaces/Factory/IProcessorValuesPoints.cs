using Familia.Domain.Entities;
using System.Collections.Generic;

namespace Familia.Domain.Interfaces.Factory
{
    public interface IProcessorValuesPoints
    {
        public void Calculate(IEnumerable<Family> families, List<Points> points);
    }
}
