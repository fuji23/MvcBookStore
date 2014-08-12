namespace MvcBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ShopID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                    })
                .PrimaryKey(t => t.ShopID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ISBN = c.String(),
                        Publisher = c.String(),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sale = c.Int(nullable: false),
                        Shop_ShopID = c.Int(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Shops", t => t.Shop_ShopID)
                .Index(t => t.Shop_ShopID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Books", new[] { "Shop_ShopID" });
            DropForeignKey("dbo.Books", "Shop_ShopID", "dbo.Shops");
            DropTable("dbo.Books");
            DropTable("dbo.Shops");
        }
    }
}
