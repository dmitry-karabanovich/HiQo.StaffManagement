using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            this.HasMany(r => r.CategoriesPositions).WithRequired(u => u.Category).HasForeignKey(u => u.CategoryId);
            this.HasRequired(g => g.Department).WithMany(r => r.DepartmentsCategories).HasForeignKey(g => g.DepartmentId);
            this.HasMany(r => r.Users).WithRequired(u => u.Category).HasForeignKey(u => u.CategoryId);
        }
    }
}
