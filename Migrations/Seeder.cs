using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DotnetCourse.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

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

    public static async Task<List<Product>> SeedAsync()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        IConfiguration config = builder.Build();

        var instanceOfClass = new UnsplashAPI(config);

        var mainImagesUrls = await instanceOfClass.GetUnsplashImageByQuery("hotel", 100);

        // mix that to every Product consist on of the food, room, attraction.
        var foodImagesUrls = await instanceOfClass.GetUnsplashImageByQuery("food", 100);
        var roomImagesUrls = await instanceOfClass.GetUnsplashImageByQuery("room", 100);
        var attractionsImagesUrls = await instanceOfClass.GetUnsplashImageByQuery("attractions", 100);

        //System.Collections.Generic.List`1[System.String]
        Console.WriteLine(mainImagesUrls);

        foreach (var image in mainImagesUrls)
        {
            Console.WriteLine(image);
        }

        // mainImagesUrls[0]
        // mainImagesUrls[1]
        // mainImagesUrls[2]

        // in the 87 iteration:
        // mainImagesUrls[87]

        var products = new List<Product>();
        var random = new Random();

        for (int i = 0; i < 100; i++)
        {
            var id = Guid.NewGuid();
            var name = _names[random.Next(_names.Length)];
            var mainImageUrl = mainImagesUrls[i];
            var imageUrls = foodImagesUrls[i] + " " + roomImagesUrls[i] + "" + attractionsImagesUrls[i];
            var location = _locations[random.Next(_locations.Length)];
            var price = random.Next(100, 500);
            var review = new List<Review>();

            products.Add(new Product(id, name, mainImageUrl, imageUrls, location, price, review, 0));
        }

        return products;
    }
}