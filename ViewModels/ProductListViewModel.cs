using System;
using DotnetCourse.Models;

namespace DotnetCourse.ViewModels
{
	public class ProductListViewModel
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MainImageUrl { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public int NumberOfReviews { get; set; }
    }
}

