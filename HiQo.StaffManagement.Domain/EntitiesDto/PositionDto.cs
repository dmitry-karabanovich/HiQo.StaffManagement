using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class PositionDto
    {
        public int PositionDtoId { get; set; }
        public string Name { get; set; }

        public int CategoryDtoId { get; set; }
        public CategoryDto Category { get; set; }

        public ICollection<UserDto> Users { get; set; }
    }
}
