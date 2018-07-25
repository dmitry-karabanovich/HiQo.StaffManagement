using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class PositionLevelDto
    {
        public int PositionLevelDtoId { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public ICollection<UserDto> Users { get; set; }
    }
}
