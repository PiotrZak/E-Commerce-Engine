using System;
using System.Diagnostics;
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
            Debugger.Launch();
            modelBuilder.Entity<Product>();

            // SEED Data
            var products = ProductSeeder.SeedAsync().Result;
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}

