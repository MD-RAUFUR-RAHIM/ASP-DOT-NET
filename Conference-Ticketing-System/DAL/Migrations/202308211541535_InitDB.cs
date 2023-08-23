namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AddConferences", newName: "Conferences");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Conferences", newName: "AddConferences");
        }
    }
}
