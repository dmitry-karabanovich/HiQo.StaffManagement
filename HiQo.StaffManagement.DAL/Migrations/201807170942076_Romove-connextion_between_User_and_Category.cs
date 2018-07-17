namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Romoveconnextion_between_User_and_Category : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "CategoryId" });
            DropColumn("dbo.Users", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "CategoryId");
            AddForeignKey("dbo.Users", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
