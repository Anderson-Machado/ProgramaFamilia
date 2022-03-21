using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Factory;
using System.Collections.Generic;
using System.Linq;

namespace Familia.Domain.PointsFactory.Process
{
    public class UpToNineHundred : IProcessorValuesPoints
    {
        public void Calculate(IEnumerable<Family> families, List<Points> points)
        {

            foreach (var item in families)
            {
                var total = item.Dependents.Where(x => x.FamilyId == item.Id).ToList().Sum(x => x.Income);

                if (total <= 900)
                {
                    var point = new Points()
                    {
                        Type = "UpToNineHundred",
                        Name = item.Name,
                        PointsFamily = 5
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
