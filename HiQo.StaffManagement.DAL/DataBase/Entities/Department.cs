using System.Collections.Generic;

namespace HiQo.StaffManagement.DAL.DataBase.Entities
{
    public class Department
    {
        public int DepartmentId{ get; set; }
        public string Name { get; set; }
        public virtual ICollection<Category> DepartmentsCategories { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Department()
        {
            DepartmentsCategories = new List<Category>();
            Users = new List<User>();
        }
    }
}
