namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Venue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Conferences", "VId", c => c.Int(nullable: false));
            CreateIndex("dbo.Conferences", "VId");
            AddForeignKey("dbo.Conferences", "VId", "dbo.Venues", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conferences", "VId", "dbo.Venues");
            DropIndex("dbo.Conferences", new[] { "VId" });
            DropColumn("dbo.Conferences", "VId");
            DropTable("dbo.Venues");
        }
    }
}
