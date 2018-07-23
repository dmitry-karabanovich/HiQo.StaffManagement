﻿using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class CategoryProfiler : Profile
    {
        private CategoryProfiler()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(categoryDto => categoryDto.Name, cfg => cfg.MapFrom(category => category.Name))
                .ForMember(categoryDto => categoryDto.Department, cfg => cfg.MapFrom(category => category.Department.Name))
                .ReverseMap()
                .ForMember(category => category.Name, cfg => cfg.MapFrom(categoryDto => categoryDto.Name))
                .ForMember(category => category.Department.Name, cfg => cfg.MapFrom(categoryDto => categoryDto.Department));
        }
    }
}