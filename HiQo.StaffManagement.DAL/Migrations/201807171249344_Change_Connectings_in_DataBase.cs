namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Connectings_in_DataBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PositionLevelId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "PositionLevelId");
            CreateIndex("dbo.Users", "CategoryId");
            CreateIndex("dbo.Users", "DepartmentId");
            AddForeignKey("dbo.Users", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels", "PositionLevelId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.Users", new[] { "CategoryId" });
            DropIndex("dbo.Users", new[] { "PositionLevelId" });
            DropColumn("dbo.Users", "DepartmentId");
            DropColumn("dbo.Users", "CategoryId");
            DropColumn("dbo.Users", "PositionLevelId");
        }
    }
}
