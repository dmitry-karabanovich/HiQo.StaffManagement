namespace HiQo.StaffManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePositionLevelConnection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Positions", "PositionLevelId", "dbo.PositionLevels");
            DropIndex("dbo.Positions", new[] { "PositionLevelId" });
            DropColumn("dbo.Positions", "PositionLevelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Positions", "PositionLevelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Positions", "PositionLevelId");
            AddForeignKey("dbo.Positions", "PositionLevelId", "dbo.PositionLevels", "PositionLevelId");
        }
    }
}
