using System;
namespace DotnetCourse.Models
{
	public class Review
	{
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        //Foreign Key
        public Guid ProductId { get; set; }
        public DateTime ReviewDate { get; set; }
        public decimal Rating { get; set; }
        public Product Product { get; set; }
    }
}

