using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
    public class RoleProfiler : Profile
    {
        public RoleProfiler()
        {
            CreateMap<Role, RoleDto>()
                .ForMember(roleDto => roleDto.RoleDtoId, cfg => cfg.MapFrom(role => role.RoleId))
                .ForMember(roleDto => roleDto.Name, cfg => cfg.MapFrom(role => role.Name))
                .ForMember(roleDto => roleDto.Users, cfg => cfg.MapFrom(role => role.Users))
                .ReverseMap();

        }
    }
}