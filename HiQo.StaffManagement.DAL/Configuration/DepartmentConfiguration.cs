using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            this.HasMany(r => r.DepartmentsCategories).WithRequired(u => u.Department).HasForeignKey(u => u.DepartmentId);
            this.HasMany(r => r.Users).WithRequired(u => u.Department).HasForeignKey(u => u.DepartmentId);
        }
    }
}
