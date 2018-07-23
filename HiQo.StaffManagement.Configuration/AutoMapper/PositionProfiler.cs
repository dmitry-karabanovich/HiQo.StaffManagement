using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class PositionProfiler : Profile
    {
        public PositionProfiler()
        {
            CreateMap<Position, PositionDto>()
                .ForMember(positionDto => positionDto.Name, cfg => cfg.MapFrom(position => position.Name))
                .ReverseMap()
                .ForMember(position => position.Name, cfg => cfg.MapFrom(positionDto => positionDto.Name));
        }
    }
}
