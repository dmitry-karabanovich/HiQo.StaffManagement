using System;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class UserDto
    {
        public int UserDtoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime DateBirth { get; set; }

        public int DepartmentDtoId { get; set; }
        public DepartmentDto Department { get; set; }

        public int PositionDtoId { get; set; }
        public PositionDto Position { get; set; }

        public int CategoryDtoId { get; set; }
        public CategoryDto Category { get; set; }

        public int RoleDtoId { get; set; }
        public RoleDto Role { get; set; }

        public int PositionLevelDtoId { get; set; }
        public PositionLevelDto PositionLevel { get; set; }
    }
}
