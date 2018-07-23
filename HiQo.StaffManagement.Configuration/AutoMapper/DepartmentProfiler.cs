using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
   public class DepartmentProfiler : Profile
    {
        DepartmentProfiler()
        {
            CreateMap<Department, DepartmentDto>()
                .ForMember(departmentDto => departmentDto.Name, cfg => cfg.MapFrom(department => department.Name));
        }
    }
}
