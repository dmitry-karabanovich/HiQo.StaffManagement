using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HiQo.StaffManagement.DAL.Configuration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.DataBase
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyContext, Migrations.Configuration>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PositionLevel> PositionLevels { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new PositionLevelConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
        }
    }
}
