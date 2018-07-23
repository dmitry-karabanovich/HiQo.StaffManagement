using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<User, UserDto>()
                .ForMember(userDto => userDto.Category, cfg => cfg.MapFrom(user => user.Category.Name))
                .ForMember(userDto => userDto.Role, cfg => cfg.MapFrom(user => user.Role.Name))
                .ForMember(userDto => userDto.Department, cfg => cfg.MapFrom(user => user.Department.Name))
                .ForMember(userDto => userDto.Position, cfg => cfg.MapFrom(user => user.Position.Name))
                .ForMember(userDto => userDto.PositionLevel, cfg => cfg.MapFrom(user => user.PositionLevel.Name))
                .ForMember(userDto => userDto.FirstName, cfg => cfg.MapFrom(user => user.FirstName))
                .ForMember(userDto => userDto.LastName, cfg => cfg.MapFrom(user => user.LastName))
                .ForMember(userDto => userDto.DateBirth, cfg => cfg.MapFrom(user => user.DateOfBirth))
                .ReverseMap()
                .ForMember(user => user.Category.Name, cfg => cfg.MapFrom(userDto => userDto.Category))
                .ForMember(user => user.Role.Name, cfg => cfg.MapFrom(userDto => userDto.Role))
                .ForMember(user => user.Department.Name, cfg => cfg.MapFrom(userDto => userDto.Department))
                .ForMember(user => user.Position.Name, cfg => cfg.MapFrom(userDto => userDto.Position))
                .ForMember(user => user.PositionLevel.Name, cfg => cfg.MapFrom(userDto => userDto.PositionLevel))
                .ForMember(user => user.FirstName, cfg => cfg.MapFrom(userDto => userDto.FirstName))
                .ForMember(user => user.LastName, cfg => cfg.MapFrom(userDto => userDto.LastName))
                .ForMember(user => user.DateOfBirth, cfg => cfg.MapFrom(userDto => userDto.DateBirth));


        }
    }
}