using System;
namespace DotnetCourse.Models
{
    public class Product
    {
        public Product() { } // Default constructor added here // for migrations

        public Product(Guid id, string name, string mainImageUrl, string imageUrls, string location, decimal price, List<Review> review, int numberOfReviews)
        {
            Id = id;
            Name = name;
            MainImageUrl = mainImageUrl;
            ImageUrls = imageUrls;
            Location = location;
            Price = price;
            Review = review;
            NumberOfReview = numberOfReviews;
        }


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MainImageUrl { get; set; }
        public string ImageUrls { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public List<Review> Review { get; set; }
        // handling number of reviews
        public int NumberOfReview { get; set; }
    }
}

