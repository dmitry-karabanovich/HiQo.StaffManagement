using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HiQo.StaffManagement.DAL.DataBase.Models
{
    public class PositionLevel
    {
        public int PositionLevelId { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public PositionLevel()
        {
            Users = new List<User>();
        }
    }
}
