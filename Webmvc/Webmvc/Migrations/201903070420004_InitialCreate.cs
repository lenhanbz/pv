namespace Webmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryOfProducts",
                c => new
                    {
                        categoryOfProductID = c.Int(nullable: false, identity: true),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.categoryOfProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        NameOfProduct = c.String(),
                        CategoryOfProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.CategoryOfProducts");
        }
    }
}
