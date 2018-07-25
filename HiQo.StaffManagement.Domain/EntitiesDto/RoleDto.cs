using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class RoleDto
    {
        public int RoleDtoId { get; set; }
        public string Name { get; set; }
        public ICollection<UserDto> Users { get; set; }
    } 
}
