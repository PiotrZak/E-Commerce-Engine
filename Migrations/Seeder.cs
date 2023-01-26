using System;
using System.Collections.Generic;
using System.Linq;
using DotnetCourse.Models;

public class ProductSeeder
{
    private static readonly string[] _names = {
        "Hotel Ritz", "Grand Hotel", "The Plaza", "The Savoy", "The Dorchester",
        "Hilton Hotel", "Marriott Hotel", "InterContinental Hotel", "Four Seasons Hotel", "The Ritz-Carlton Hotel",
        "The Westin Hotel", "The Luxury Collection Hotel", "W Hotels", "Sheraton Hotel", "Le Meridien Hotel",
        "The St. Regis Hotel", "The Wydham Hotel", "The Hyatt Hotel", "The Radisson Hotel", "The Crowne Plaza Hotel",
        "The Mandarin Oriental Hotel", "The Park Hyatt Hotel", "The Fairmont Hotel", "The Sofitel Hotel", "The Novotel Hotel",
        "The Shangri-La Hotel", "The Mandarin Hotel", "The Peninsula Hotel", "The Waldorf Astoria Hotel", "The Raffles Hotel",
        "The Rosewood Hotel", "The Belmond Hotel", "The Aman Hotel", "The Banyan Tree Hotel", "The Mandarin Oriental Hotel",
        "The Oberoi Hotel", "The Mandarin Oriental Hotel", "The Rosewood Hotel", "The Belmond Hotel", "The Aman Hotel",
        "The Banyan Tree Hotel", "The Mandarin Oriental Hotel", "The Oberoi Hotel", "The Mandarin Oriental Hotel",
        "The Rosewood Hotel", "The Belmond Hotel", "The Aman Hotel", "The Banyan Tree Hotel"
    };
    private static readonly string[] _locations = { "Paris", "New York", "London", "Tokyo", "Sydney" };
    private static readonly string[] _imageUrls = { "image1.jpg", "image2.jpg", "image3.jpg", "image4.jpg", "image5.jpg" };

    public static List<Product> Seed()
    {
        var products = new List<Product>();
        var random = new Random();

        for (int i = 0; i < 1000; i++)
        {
            var id = Guid.NewGuid();
            var name = _names[random.Next(_names.Length)];
            var mainImageUrl = "main" + _imageUrls[random.Next(_imageUrls.Length)];
            var imageUrls = _imageUrls.Select(x => x).ToString();
            var location = _locations[random.Next(_locations.Length)];
            var price = random.Next(100, 500);
            var rating = random.NextDouble() * 5;

            products.Add(new Product(id, name, mainImageUrl, imageUrls, location, price, rating));
        }

        return products;
    }
}