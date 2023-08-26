namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseCats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        E_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCats", t => t.E_Id, cascadeDelete: true)
                .Index(t => t.E_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expenses", "E_Id", "dbo.ExpenseCats");
            DropIndex("dbo.Expenses", new[] { "E_Id" });
            DropTable("dbo.Expenses");
            DropTable("dbo.ExpenseCats");
        }
    }
}
