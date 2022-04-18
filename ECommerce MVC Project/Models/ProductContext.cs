using Microsoft.EntityFrameworkCore;
namespace ECommerce_MVC_Project.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext>options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
        }
    }
}
