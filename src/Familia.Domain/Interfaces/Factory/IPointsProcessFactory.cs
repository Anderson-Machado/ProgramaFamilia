using Familia.Domain.Enums;

namespace Familia.Domain.Interfaces.Factory
{
    public interface IPointsProcessFactory
    {
        public IProcessorValuesPoints CreateValuesPoints(EPointsValueType pointsValueType);
    }
}
