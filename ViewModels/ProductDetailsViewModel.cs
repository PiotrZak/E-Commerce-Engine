using System;
using DotnetCourse.Models;

namespace DotnetCourse.ViewModels
{
	public class ProductDetailsViewModel
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MainImageUrl { get; set; }
        public string ImageUrls { get; set; }
        public string PreciseLocation { get; set; }
        public decimal Price { get; set; }
    }
}

