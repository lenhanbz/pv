namespace Webmvc_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Webmvc_demo.Models.ProductDbContext1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Webmvc_demo.Models.ProductDbContext1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Products.AddOrUpdate(p => p.productID,
                new Models.Product { productID = 1, productName ="Quat may",categoryOfProductID =1},
                new Models.Product { productID = 2, productName ="May giat", categoryOfProductID =2}

                );
            context.CategoryOfProducts.AddOrUpdate(c => c.categoryOfProductID,
                new Models.CategoryOfProduct { categoryOfProductID = 1, description = "Do dien tu"},
                new Models.CategoryOfProduct { categoryOfProductID = 2, description = "Do gia dung"}

                );
        }
    }
}
