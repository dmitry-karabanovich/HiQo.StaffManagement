using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Entities;

namespace HiQo.StaffManagement.DAL.Configuration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            HasMany(r => r.CategoriesPositions).WithRequired(u => u.Category).HasForeignKey(u => u.CategoryId).WillCascadeOnDelete(false);
            HasRequired(g => g.Department).WithMany(r => r.DepartmentsCategories).HasForeignKey(g => g.DepartmentId);
            HasMany(r => r.Users).WithRequired(u => u.Category).HasForeignKey(u => u.CategoryId).WillCascadeOnDelete(false);
        }
    }
}
