using System.Collections.Generic;

namespace HiQo.StaffManagement.DAL.DataBase.Entities
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
