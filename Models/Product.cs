using System;
namespace DotnetCourse.Models
{
    public class Product
    {
        public Product() { } // Default constructor added here // for migrations

        public Product(Guid id, string name, string mainImageUrl, string imageUrls, string location, decimal price, double rating)
        {
            Id = id;
            Name = name;
            MainImageUrl = mainImageUrl;
            ImageUrls = imageUrls;
            Location = location;
            Price = price;
            Rating = rating;
        }


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MainImageUrl { get; set; }
        public string ImageUrls { get; set; } // serialized string
        public string Location { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
    }
}

