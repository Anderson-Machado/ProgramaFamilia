using AutoMapper;
using Familia.Application.Interfaces;
using Familia.Application.ViewModel;
using Familia.Domain.Entities;
using Familia.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Familia.Application.AppServices
{
    public class PointsAppServices : IPointsAppServices
    {
        private readonly IPointsServices _services;
        private readonly IMapper _mapper;

        public PointsAppServices(IPointsServices services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PointsViewModel>> GetPointsFamily()
        {
            return _mapper.Map<IEnumerable<Points>, IEnumerable<PointsViewModel>>(await _services.GetPointsFamily());
        }
    }
}
