using System;
namespace DotnetCourse.Models
{
	public class ReviewQuery
	{
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Rating { get; set; }
    }
}

