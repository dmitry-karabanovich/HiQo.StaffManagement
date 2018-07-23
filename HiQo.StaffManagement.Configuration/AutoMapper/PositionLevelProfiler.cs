using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class PositionLevelProfiler : Profile
    {
        public PositionLevelProfiler()
        {
            CreateMap<PositionLevel, PositionLevelDto>()
                .ForMember(positionLevelDto => positionLevelDto.Name,cfg => cfg.MapFrom(positionLevel => positionLevel.Name))
                .ForMember(positionLevelDto => positionLevelDto.Level,cfg => cfg.MapFrom(positionLevel => positionLevel.Level))
                .ReverseMap()
                .ForMember(positionLevel => positionLevel.Name, cfg => cfg.MapFrom(positionLevelDto => positionLevelDto.Name))
                .ForMember(positionLevel => positionLevel.Level,cfg => cfg.MapFrom(positionLevelDto => positionLevelDto.Level));
        }
    }
}