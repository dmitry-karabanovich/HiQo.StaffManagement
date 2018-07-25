using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class CategoryDto
    {
        public int CategoryDtoId { get; set; }
        public string Name { get; set; }

        public int DepartmentDtoId { get; set; }
        public DepartmentDto Department { get; set; }

        public ICollection<PositionDto> Positions { get; set; }
        public ICollection<UserDto> Users { get; set; }
    }
}
