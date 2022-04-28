//using Microsoft.EntityFrameworkCore;
//namespace ECommerce_MVC_Project.Models
//{
//    //db
//    public class ProductContext : DbContext
//    {
//        public ProductContext(DbContextOptions<ProductContext> options) : base(options)//calling base class constructor to initialize
//        {

//        }
//        //tables
//        public DbSet<Product> Products { get; set; }

//        //data seeding:adding dummy data in db table
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {


//            modelBuilder.Entity<Product>().HasData(
//                new Product { Id = 1, Name = "Jordan Retro 11", Description = "The Air Jordan 11 Cool Grey (2021) features a Cool Grey Durabuck upper with patent leather overlays and a signature Jumpman embroidery on the collar. ", Price = 190, ImageName = "3.jpg" },
//                new Product { Id = 2, Name = "Yeezy Wave Runners", Description = "The Yeezy 700 Boost Wave Runner is the shoe that led Yeezy's pivot from a sleek, minimal aesthetic to a chunky, 90s inspired one. ", Price = 300, ImageName = "4.jpg" }

//                );
//        }
//    }
//}
