using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class PositionProfiler : Profile
    {
        public PositionProfiler()
        {
            CreateMap<Position, PositionDto>()
                .ForMember(positionDto => positionDto.Name, cfg => cfg.MapFrom(position => position.Name));
        }
    }
}
