using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            this.Property(g => g.Name).IsRequired().HasMaxLength(30);
            this.HasRequired(g => g.Category).WithMany(r => r.CategoriesPositions).HasForeignKey(g => g.CategoryId);
            this.HasRequired(g => g.PositionLevel).WithMany(r => r.Positions).HasForeignKey(g => g.PositionLevelId);
        }
    }
}
