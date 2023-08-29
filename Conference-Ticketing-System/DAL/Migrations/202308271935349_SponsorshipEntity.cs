namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SponsorshipEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsorships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SponsorCompanyName = c.String(nullable: false),
                        ContactEmail = c.String(nullable: false),
                        ContactPhone = c.String(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ConferenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Conferences", t => t.ConferenceId, cascadeDelete: true)
                .Index(t => t.ConferenceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sponsorships", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.Sponsorships", new[] { "ConferenceId" });
            DropTable("dbo.Sponsorships");
        }
    }
}
