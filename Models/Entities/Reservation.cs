using System;
namespace DotnetCourse.Models.Entities
{
	public class Reservation
	{
		public Guid Id { get; set; }
		public Guid ProductId { get; set; }
		public DateTime StartReservationDate { get; set; }
		public DateTime EndReservationDate { get; set; }
        public Product Product { get; set; }
    }
}

