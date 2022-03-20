using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Factory;
using System.Collections.Generic;
using System.Linq;

namespace Familia.Domain.PointsFactory.Process
{
    internal class FromNineHundredToOneThousandFiveHundred : IProcessorValuesPoints
    {
        public void Calculate(IEnumerable<Family> families, List<Points> points)
        {
            foreach (var item in families)
            {
                var total = item.Dependents.Where(x => x.FamilyId == item.Id).ToList().Sum(x => x.Income);

                if (total >= 901 && total <= 1500)
                {
                    var point = new Points()
                    {
                        Type = "FromNineHundredToOneThousandFiveHundred",
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
