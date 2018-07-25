using HiQo.StaffManagement.DAL.Migrations.Helpers;

namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVanyaDmitrovichUser : DbMigration
    {
        public override void Up()
        {
            Sql(SqlFileHelper.GetFile("Trainning.sql"));
        }
        
        public override void Down()
        {
        }
    }
}
