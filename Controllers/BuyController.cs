using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.Models.Entities;
using Microsoft.AspNetCore.Mvc;
namespace DotnetCourse.Controllers;

[ApiController]
[Route("[controller]")]
public class BuyController : ControllerBase
{
    private readonly IReservationQueries _reservationQueries;

    public BuyController(IReservationQueries reservationQueries)
    {
        _reservationQueries = reservationQueries;
    }

    [HttpPost("Buy")]
    public int BuyProduct(BuyQuery buyQuery)
    {
        try
        {
            //Frontend send current date - or its generate on the backend 
            var isReservedUntil = _reservationQueries.IsReserveUntil(buyQuery.ProductId, buyQuery.Date);

            if (isReservedUntil != null) {
                DateTime reservedUntil = (DateTime)isReservedUntil;
                TimeSpan timeLeft = reservedUntil - DateTime.Now;
                throw new Exception($"This product is already reserved. {timeLeft.TotalMinutes} minutes left until the reservation expires.");
            }

            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                ProductId = buyQuery.ProductId,
                StartReservationDate = buyQuery.Date,
                EndReservationDate = buyQuery.Date.AddHours(1),
            };

            var data = _reservationQueries.InsertReservation(reservation);

            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }
}


