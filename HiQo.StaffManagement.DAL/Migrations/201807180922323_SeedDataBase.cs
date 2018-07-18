namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDataBase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Positions", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Users", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Users", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            AddForeignKey("dbo.Positions", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: false);
            AddForeignKey("dbo.Categories", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "PositionId", "dbo.Positions", "PositionId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels", "PositionLevelId", cascadeDelete: false);
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "RoleId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels");
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Users", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Users", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Positions", "CategoryId", "dbo.Categories");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "RoleId");
            AddForeignKey("dbo.Users", "PositionLevelId", "dbo.PositionLevels", "PositionLevelId");
            AddForeignKey("dbo.Users", "DepartmentId", "dbo.Departments", "DepartmentId");
            AddForeignKey("dbo.Users", "PositionId", "dbo.Positions", "PositionId");
            AddForeignKey("dbo.Users", "CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Categories", "DepartmentId", "dbo.Departments", "DepartmentId");
            AddForeignKey("dbo.Positions", "CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
