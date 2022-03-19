using Familia.Domain.Enums;
using Familia.Domain.Interfaces.Factory;
using Familia.Domain.PointsFactory.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familia.Domain.PointsFactory.Factory
{
    public class PointsProcessFactory : IPointsProcessFactory
    {
        public IProcessorValuesPoints CreateValuesPoints(EPointsValueType pointsValueType)
        {
            switch (pointsValueType)
            {
                case EPointsValueType.UpToNineHundred: return new UpToNineHundred();
                case EPointsValueType.FromNineHundredToOneThousandFiveHundred: return new FromNineHundredToOneThousandFiveHundred();
                case EPointsValueType.WithThreeOrMoreDependents: return new WithThreeOrMoreDependents();
                case EPointsValueType.WithOneOrTwoDependents: return new WithOneOrTwoDependents();
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
