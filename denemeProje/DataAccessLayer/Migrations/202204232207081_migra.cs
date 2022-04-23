namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CatName = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.CatID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        prID = c.Int(nullable: false, identity: true),
                        prName = c.String(maxLength: 40),
                        CatID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.prID)
                .ForeignKey("dbo.Categories", t => t.CatID, cascadeDelete: true)
                .Index(t => t.CatID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CatID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CatID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
