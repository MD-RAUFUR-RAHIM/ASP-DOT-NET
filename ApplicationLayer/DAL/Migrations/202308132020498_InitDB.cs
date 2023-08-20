namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddConferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Details = c.String(),
                        Topic = c.String(),
                        Date = c.DateTime(nullable: false),
                        VenueName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrganizerRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrganizerRegistrations");
            DropTable("dbo.AddConferences");
        }
    }
}
