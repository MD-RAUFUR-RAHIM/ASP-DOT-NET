namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Token : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TokenOrganizers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        Organizer_Id = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrganizerRegistrations", t => t.Organizer_Id, cascadeDelete: true)
                .Index(t => t.Organizer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TokenOrganizers", "Organizer_Id", "dbo.OrganizerRegistrations");
            DropIndex("dbo.TokenOrganizers", new[] { "Organizer_Id" });
            DropTable("dbo.TokenOrganizers");
        }
    }
}
