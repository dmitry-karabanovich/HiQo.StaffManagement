using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using HiQo.StaffManagement.DAL.DataBase;

namespace HiQo.StaffManagement.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CompanyContext context)
        {
        }
    }
}