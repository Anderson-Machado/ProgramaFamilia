using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familia.Domain.PointsFactory.Process
{
    public class WithOneOrTwoDependents : IProcessorValuesPoints
    {
        public void Calculate(IEnumerable<Family> families, List<Points> points)
        {
            foreach (var item in families)
            {
                var total = item.Dependents.Where(x => x.FamilyId == item.Id && x.Age < 18).Count();

                if (total >= 1 && total<=2)
                {
                    var point = new Points()
                    {
                        Name = item.Name,
                        PointsFamily = 2
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
