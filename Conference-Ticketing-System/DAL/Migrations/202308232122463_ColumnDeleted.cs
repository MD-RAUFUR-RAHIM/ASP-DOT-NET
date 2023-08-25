namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Conferences", "VenueName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Conferences", "VenueName", c => c.String());
        }
    }
}
