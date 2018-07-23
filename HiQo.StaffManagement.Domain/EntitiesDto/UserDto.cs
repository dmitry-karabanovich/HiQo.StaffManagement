using System;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Category { get; set; }
        public string Role { get; set; }
        public int PositionLevel { get; set; }
    }
}
