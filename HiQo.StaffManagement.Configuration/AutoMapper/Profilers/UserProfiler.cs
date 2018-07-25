using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<User, UserDto>()
                .ForMember(userDto => userDto.UserDtoId, cfg => cfg.MapFrom(user => user.UserId))
                .ForMember(userDto => userDto.FirstName, cfg => cfg.MapFrom(user => user.FirstName))
                .ForMember(userDto => userDto.LastName, cfg => cfg.MapFrom(user => user.LastName))
                .ForMember(userDto => userDto.DateBirth, cfg => cfg.MapFrom(user => user.DateOfBirth))
                .ForMember(userDto => userDto.CategoryDtoId, cfg => cfg.MapFrom(user => user.CategoryId))
                .ForMember(userDto => userDto.Category, cfg => cfg.MapFrom(user => user.Category))
                .ForMember(userDto => userDto.RoleDtoId, cfg => cfg.MapFrom(user => user.RoleId))
                .ForMember(userDto => userDto.Role, cfg => cfg.MapFrom(user => user.Role))
                .ForMember(userDto => userDto.DepartmentDtoId, cfg => cfg.MapFrom(user => user.DepartmentId))
                .ForMember(userDto => userDto.Department, cfg => cfg.MapFrom(user => user.Department))
                .ForMember(userDto => userDto.PositionDtoId, cfg => cfg.MapFrom(user => user.PositionId))
                .ForMember(userDto => userDto.Position, cfg => cfg.MapFrom(user => user.Position))
                .ForMember(userDto => userDto.PositionLevelDtoId, cfg => cfg.MapFrom(user => user.PositionLevelId))
                .ForMember(userDto => userDto.PositionLevel, cfg => cfg.MapFrom(user => user.PositionLevel))
                .ReverseMap();
        }
    }
}