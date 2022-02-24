using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCsharp03.Models
{
    public class PortoDbContext : DbContext
    {
        public PortoDbContext(DbContextOptions<PortoDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
            new Slider { Id = 1, Image = "slide1.jpg", ClothType = "on Jackets", DisCount = "Get up to 30% off", Price = 199, TrendWord = "Winter Fashion Trends" },
            new Slider { Id = 2, Image = "slide2.jpg", ClothType = "on Coat", DisCount = "Get up to 20% off", Price = 300, TrendWord = "Season Fashion Trends" }
            );
        }

    }
}
