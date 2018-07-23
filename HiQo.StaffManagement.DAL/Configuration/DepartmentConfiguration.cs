using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Entities;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            HasMany(r => r.DepartmentsCategories).WithRequired(u => u.Department).HasForeignKey(u => u.DepartmentId).WillCascadeOnDelete(false);
            HasMany(r => r.Users).WithRequired(u => u.Department).HasForeignKey(u => u.DepartmentId).WillCascadeOnDelete(false);
        }
    }
}
