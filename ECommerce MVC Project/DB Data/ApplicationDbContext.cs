using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECommerce_MVC_Project.Models;
using System.Collections.Generic;
using System;

namespace ECommerce_MVC_Project.DB_Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //internal object GetProduct(int? id)
        //{
        //    throw new NotImplementedException();
        //}

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
