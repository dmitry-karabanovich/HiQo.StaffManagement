using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
    public class CategoryProfiler : Profile
    {
        public CategoryProfiler()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(categoryDto => categoryDto.CategoryDtoId, cfg => cfg.MapFrom(category => category.CategoryId))
                .ForMember(categoryDto => categoryDto.Name, cfg => cfg.MapFrom(category => category.Name))
                .ForMember(categoryDto => categoryDto.DepartmentDtoId, cfg => cfg.MapFrom(category => category.DepartmentId))
                .ForMember(categoryDto => categoryDto.Department, cfg => cfg.MapFrom(category => category.Department))
                .ForMember(categoryDto => categoryDto.Positions, cfg => cfg.MapFrom(category => category.CategoriesPositions))
                .ForMember(categoryDto => categoryDto.Users, cfg => cfg.MapFrom(category => category.Users))
                .ReverseMap();
                
        }
    }
}