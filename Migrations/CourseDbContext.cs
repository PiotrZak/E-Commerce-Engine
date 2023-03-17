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
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Debugger.Launch();

            modelBuilder.Entity<Product>()
                .HasMany(x => x.Review)
                .WithOne(x => x.Product)
                .IsRequired();

            // SEED Data
            var products = ProductSeeder.SeedAsync().Result;
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Review>()
                .HasData(new Review
                {
                    Id = Guid.NewGuid(),
                    ProductId = products[0].Id,
                    UserId = new Guid(),
                    ReviewDate = new DateTime(),
                    Rating = 4
                }, new Review
                {
                    Id = Guid.NewGuid(),
                    ProductId = products[0].Id,
                    UserId = Guid.NewGuid(),
                    ReviewDate = new DateTime(),
                    Rating = 3
                }
            );
        }
    }
}

