using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class RoleProfiler : Profile
    {
        public RoleProfiler()
        {
            CreateMap<Role, RoleDto>()
                .ForMember(roleDto => roleDto.Name, cfg => cfg.MapFrom(role => role.Name));
        }
    }
}