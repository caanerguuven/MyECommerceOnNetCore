using Microsoft.EntityFrameworkCore;
using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class MyECommerceContext : DbContext
    {
        public MyECommerceContext(DbContextOptions<MyECommerceContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(pk => new { pk.ProductId, pk.CategoryId });
        }
    }
}
