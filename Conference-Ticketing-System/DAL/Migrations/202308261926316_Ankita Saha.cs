namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnkitaSaha : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auditoriums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        A_Capacity = c.Int(nullable: false),
                        A_Name = c.String(nullable: false),
                        Venue_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Venues", t => t.Venue_id, cascadeDelete: true)
                .Index(t => t.Venue_id);
            
            AddColumn("dbo.Venues", "Venue_Location", c => c.String(nullable: false));
            AddColumn("dbo.Venues", "Venue_Capacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Auditoriums", "Venue_id", "dbo.Venues");
            DropIndex("dbo.Auditoriums", new[] { "Venue_id" });
            DropColumn("dbo.Venues", "Venue_Capacity");
            DropColumn("dbo.Venues", "Venue_Location");
            DropTable("dbo.Auditoriums");
        }
    }
}
