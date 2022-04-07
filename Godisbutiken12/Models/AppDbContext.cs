using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Godis> Godisar { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Soft Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Hard Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Fruit Candy" });

            modelBuilder.Entity<Godis>().HasData(new Godis
            {
                GodisID = 1,
                Name = "Assorted Soft Candy",
                Price = 5,
                Description = "Bästa godis!",
                CategoryId = 1,
                ImageUrl = "\\images\\Softcandy.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\Thumbnailsoftcandy.jpg",
                IsInStock=true,
                IsOnSale=true,


            });
            modelBuilder.Entity<Godis>().HasData(new Godis
            {
                GodisID = 2,
                Name = "Assorted Hard Candy",
                Price = 3,
                Description = "Bästa godis!",
                CategoryId = 2,
                ImageUrl = "\\images\\Hardcandybild.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\Hardcandythumbnail.jpg",
                IsInStock = true,
                IsOnSale = true,


            });
            modelBuilder.Entity<Godis>().HasData(new Godis
            {
                GodisID = 3,
                Name = "Assorted Fruit Candy",
                Price = 4,
                Description = "Bästa godis!",
                CategoryId = 3,
                ImageUrl = "\\images\\fruitcandy.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\fruitcandythumbnail.jpg",
                IsInStock = true,
                IsOnSale = true,


            });
        }
    }
}
