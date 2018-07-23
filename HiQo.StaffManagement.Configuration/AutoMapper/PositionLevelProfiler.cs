using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class PositionLevelProfiler : Profile
    {
        public PositionLevelProfiler()
        {
            CreateMap<PositionLevel, PositionLevelDto>()
                .ForMember(positionLevelDto => positionLevelDto.Name,
                    cfg => cfg.MapFrom(positionLevel => positionLevel.Name))
                .ForMember(positionLevelDto => positionLevelDto.Level,
                    cfg => cfg.MapFrom(positionLevel => positionLevel.Level));
        }
    }
}