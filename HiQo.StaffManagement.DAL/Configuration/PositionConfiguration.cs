using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Entities;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            HasRequired(g => g.Category).WithMany(r => r.CategoriesPositions).HasForeignKey(g => g.CategoryId);
        }
    }
}
