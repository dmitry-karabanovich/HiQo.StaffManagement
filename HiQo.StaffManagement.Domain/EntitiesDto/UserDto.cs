using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.EntitiesDto
{
    class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Category { get; set; }
        public int PositionLevel { get; set; }
    }
}
