using System;
using DotnetCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCourse.Migrations
{
	public class CourseDbContext : DbContext
	{
        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options) {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();

            // SEED Data
            var products = ProductSeeder.Seed();
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}

