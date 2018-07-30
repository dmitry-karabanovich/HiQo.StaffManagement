using AutoMapper;
using HiQo.StaffManagement.Core.Models;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profilers
{
    public class UpsertUserProfile : Profile
    {
        public UpsertUserProfile()
        {
            CreateMap<UserDto, UpsertUser>()
                .ForMember(upsertUser => upsertUser.UpsertUserId, cfg => cfg.MapFrom(user => user.UserDtoId))
                .ForMember(upsertUser => upsertUser.FirstName, cfg => cfg.MapFrom(user => user.FirstName))
                .ForMember(upsertUser => upsertUser.LastName, cfg => cfg.MapFrom(user => user.LastName))
                .ForMember(upsertUser => upsertUser.DateOfBirth,
                    cfg => cfg.MapFrom(user => user.DateBirth.ToString("yyyy/MM/dd")))
                .ForMember(upsertUser => upsertUser.DepartmentId, cfg => cfg.MapFrom(user => user.DepartmentDtoId))
                .ForMember(upsertUser => upsertUser.CategoryId, cfg => cfg.MapFrom(user => user.CategoryDtoId))
                .ForMember(upsertUser => upsertUser.PositionId, cfg => cfg.MapFrom(user => user.PositionDtoId))
                .ForMember(upsertUser => upsertUser.PositionLevelId, cfg => cfg.MapFrom(user => user.PositionLevelDtoId))
                .ForMember(upsertUser => upsertUser.RoleId, cfg => cfg.MapFrom(user => user.RoleDtoId))
                .ReverseMap()
                .ForMember(user => user.Department, cfg => cfg.Ignore())
                .ForMember(user => user.Category, cfg => cfg.Ignore())
                .ForMember(user => user.Position, cfg => cfg.Ignore())
                .ForMember(user => user.PositionLevel, cfg => cfg.Ignore())
                .ForMember(user => user.Role, cfg => cfg.Ignore());
        }
    }
}
