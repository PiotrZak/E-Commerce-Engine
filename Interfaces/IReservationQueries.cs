
using System;
using DotnetCourse.Models;
using DotnetCourse.Models.Entities;

namespace DotnetCourse.Interfaces
{
    public interface IReservationQueries
    {
        int InsertReservation(Reservation reservationQuery);
        DateTime? IsReserveUntil(Guid productId, DateTime date);
    }
}
