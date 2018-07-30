using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class SharedInfoDto
    {
        public IEnumerable<DepartmentDto> DepartmentDtos { get; set; }
        public IEnumerable<CategoryDto> CategoryDtos { get; set; }
        public IEnumerable<PositionDto> PositionDtos { get; set; }
        public IEnumerable<PositionLevelDto> PositionLevelDtos { get; set; }
        public IEnumerable<RoleDto> RoleDtos { get; set; }
    }
}
