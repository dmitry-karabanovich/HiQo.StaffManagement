using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class DepartmentDto
    {
        public int DepartmentDtoId {get; set; }
        public string Name { get; set; }
        
        public ICollection<CategoryDto> Categories { get; set; }
        public ICollection<UserDto> Users { get; set; }

    }
}
