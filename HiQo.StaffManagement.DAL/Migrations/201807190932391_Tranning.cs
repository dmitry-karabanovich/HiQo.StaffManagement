using System.Data.Entity.Migrations;
using System.IO;
using HiQo.StaffManagement.DAL.Migrations.Helpers;

namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;

    public partial class Tranning : DbMigration
    {
        public override void Up()
        {
            Sql(SqlFileHelper.GetFile());           
        }
        
        public override void Down()
        {
        }
    }
}
