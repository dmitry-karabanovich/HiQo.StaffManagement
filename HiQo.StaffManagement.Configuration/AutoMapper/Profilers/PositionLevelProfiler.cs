using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
    public class PositionLevelProfiler : Profile
    {
        public PositionLevelProfiler()
        {
            CreateMap<PositionLevel, PositionLevelDto>()
                .ForMember(positionLevelDto => positionLevelDto.PositionLevelDtoId, cfg => cfg.MapFrom(positionLevel => positionLevel.PositionLevelId))
                .ForMember(positionLevelDto => positionLevelDto.Name, cfg => cfg.MapFrom(positionLevel => positionLevel.Name))
                .ForMember(positionLevelDto => positionLevelDto.Level, cfg => cfg.MapFrom(positionLevel => positionLevel.Level))
                .ForMember(positionLevelDto => positionLevelDto.Users, cfg => cfg.MapFrom(positionLevel => positionLevel.Users))
                .ReverseMap();

        }
    }
}