using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familia.Domain.PointsFactory.Process
{
    public class WithThreeOrMoreDependents : IProcessorValuesPoints
    {
        public void Calculate(IEnumerable<Family> families, List<Points> points)
        {
            foreach (var item in families)
            {
                var total = item.Dependents.Where(x => x.IdFamily == item.Id).Count();

                if (total >= 3)
                {
                    var point = new Points()
                    {
                        Name = item.Name,
                        PointsFamily = 3
                    };
                    if (!points.Contains(point))
                    {
                        points.Add(point);
                    }
                }

            }
        }
    }
}
