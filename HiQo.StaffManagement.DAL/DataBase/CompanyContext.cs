﻿using System.Data.Entity;
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

        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<PositionLevel> PositionLevels { get; set; }
        public IDbSet<Department> Departments { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Position> Positions { get; set; }

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
