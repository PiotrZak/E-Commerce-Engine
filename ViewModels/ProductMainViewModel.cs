using System;
using DotnetCourse.Models;

namespace DotnetCourse.ViewModels
{
	public class ProductMainViewModel
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MainImageUrl { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}

