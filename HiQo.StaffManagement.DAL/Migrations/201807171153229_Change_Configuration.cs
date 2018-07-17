namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Configuration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Positions", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Positions", new[] { "Category_CategoryId" });
            RenameColumn(table: "dbo.Positions", name: "Category_CategoryId", newName: "CategoryId");
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Positions", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Positions", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.PositionLevels", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 25));
            CreateIndex("dbo.Positions", "CategoryId");
            AddForeignKey("dbo.Positions", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Positions", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Positions", new[] { "CategoryId" });
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.PositionLevels", "Name", c => c.String());
            AlterColumn("dbo.Positions", "CategoryId", c => c.Int());
            AlterColumn("dbo.Positions", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            RenameColumn(table: "dbo.Positions", name: "CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.Positions", "Category_CategoryId");
            AddForeignKey("dbo.Positions", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
