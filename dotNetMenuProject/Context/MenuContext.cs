using System;
using dotNetMenuProject.Entities;
using Microsoft.EntityFrameworkCore;
namespace dotNetMenuProject.Context
{
	public class MenuContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=dotNetMenuDB;Username=postgres;Password=1234;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}

