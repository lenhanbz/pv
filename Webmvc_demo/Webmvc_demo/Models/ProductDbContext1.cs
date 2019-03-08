namespace Webmvc_demo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDbContext1 : DbContext
    {
        public ProductDbContext1()
            : base("name=ProductDbContext1")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryOfProduct> CategoryOfProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
