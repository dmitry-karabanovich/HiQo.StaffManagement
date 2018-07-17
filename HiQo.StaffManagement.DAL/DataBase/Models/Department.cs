using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HiQo.StaffManagement.DAL.DataBase.Models
{
    public class Department
    {
        public int DepartmentId{ get; set; }
        public string Name { get; set; }
        public virtual ICollection<Category> DepartmentsCategories { get; set; }
        public Department()
        {
            DepartmentsCategories = new List<Category>();
        }
    }
}
