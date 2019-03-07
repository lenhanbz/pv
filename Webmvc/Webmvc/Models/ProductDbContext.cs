namespace Webmvc.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("name=ProductDbContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryOfProduct> CategoryOfProducts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
