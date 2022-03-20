using Familia.Domain.Entities;
using Familia.Domain.Enums;
using Familia.Domain.Interfaces.Factory;
using System.Collections.Generic;

namespace Familia.Domain.PointsFactory
{
    public class ProviderPoints : IProviderPoints
    {
        private readonly IPointsProcessFactory _processFactory;

        public ProviderPoints(IPointsProcessFactory processFactory)
        {
            _processFactory = processFactory;
        }

        public void GeneratePointsValues(IEnumerable<Family> families, List<Points> points)
        {
            _processFactory.CreateValuesPoints(EPointsValueType.UpToNineHundred).Calculate(families, points);
            _processFactory.CreateValuesPoints(EPointsValueType.FromNineHundredToOneThousandFiveHundred).Calculate(families, points);
            _processFactory.CreateValuesPoints(EPointsValueType.WithThreeOrMoreDependents).Calculate(families, points);
            _processFactory.CreateValuesPoints(EPointsValueType.WithOneOrTwoDependents).Calculate(families, points);

        }

    }
}
