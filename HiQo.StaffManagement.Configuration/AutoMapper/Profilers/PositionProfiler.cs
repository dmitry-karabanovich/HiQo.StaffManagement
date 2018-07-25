using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
    public class PositionProfiler : Profile
    {
        public PositionProfiler()
        {
            CreateMap<Position, PositionDto>()
                .ForMember(positionDto => positionDto.PositionDtoId, cfg => cfg.MapFrom(position => position.PositionId))
                .ForMember(positionDto => positionDto.Name, cfg => cfg.MapFrom(position => position.Name))
                .ForMember(positionDto => positionDto.CategoryDtoId, cfg => cfg.MapFrom(position => position.CategoryId))
                .ForMember(positionDto => positionDto.Category, cfg => cfg.MapFrom(position => position.Category))
                .ForMember(positionDto => positionDto.Users, cfg => cfg.MapFrom(position => position.Users))
                .ReverseMap();

        }
    }
}
