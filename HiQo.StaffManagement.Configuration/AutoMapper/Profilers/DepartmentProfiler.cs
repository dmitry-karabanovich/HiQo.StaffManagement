using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
   public class DepartmentProfiler : Profile
    {
        public DepartmentProfiler()
        {
            CreateMap<Department, DepartmentDto>()
                .ForMember(departmentDto => departmentDto.DepartmentDtoId, cfg => cfg.MapFrom(department => department.DepartmentId))
                .ForMember(departmentDto => departmentDto.Name, cfg => cfg.MapFrom(department => department.Name))
                .ForMember(departmentDto => departmentDto.Categories, cfg => cfg.MapFrom(department => department.DepartmentsCategories))
                .ForMember(departmentDto => departmentDto.Users, cfg => cfg.MapFrom(department => department.Users))
                .ReverseMap();
        }
    }
}
