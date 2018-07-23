using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Models;
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
                .ForMember(userDto => userDto.DateBirth, cfg => cfg.MapFrom(user => user.DateOfBirth));
        }
    }
}