using AutoMapper;
using Familia.Application.ViewModel;
using Familia.Domain.Entities;

namespace Familia.Application.AutoMapper
{
    internal class DomainAnViewModelMappingProfile : Profile
    {
        public DomainAnViewModelMappingProfile()
        {
            CreateMap<Points, PointsViewModel>().ReverseMap();
           
        }
    }
}
