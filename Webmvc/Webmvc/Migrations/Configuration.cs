namespace Webmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Webmvc.Models.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Webmvc.Models.ProductDbContext";
        }

        protected override void Seed(Webmvc.Models.ProductDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.CategoryOfProducts.AddOrUpdate(c => c.categoryOfProductID,
                new Models.CategoryOfProduct { categoryOfProductID = 111, description = "Do dien tu" },
                new Models.CategoryOfProduct { categoryOfProductID = 122, description = "Do gia dung" }
                );
            context.Products.AddOrUpdate(p => p.productID,
                new Models.Product { productID = 1, NameOfProduct ="Quat dien", CategoryOfProductID = 111},
                new Models.Product { productID = 2, NameOfProduct = "Chao", CategoryOfProductID = 122},
                new Models.Product { productID = 5, NameOfProduct = "Chen", CategoryOfProductID = 122 }
                );
        }
    }
}
