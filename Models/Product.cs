using System;
namespace DotnetCourse.Models
{
    public class Product
    {
        public Product(Guid id, string name, string location, decimal price, double rating)
        {
            Id = id;
            Name = name;
            Location = location;
            Price = price;
            Rating = rating;
        }


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; } // 5 - int, 5.5 - decimal
    }

}

