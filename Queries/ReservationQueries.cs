
using System;
using Dapper;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.Models.Entities;
using DotnetCourse.ViewModels;
using Microsoft.Data.SqlClient;

namespace DotnetCourse.Queries
{
    public class ReservationQueries : IReservationQueries
    {
        public IConfiguration _configuration;

        public ReservationQueries(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int InsertReservation(Reservation reservationQuery)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            string insertQuery = @"INSERT INTO dbo.Reservations
                (
                    Id,
                    ProductId,
                    StartReservationDate,
                    EndReservationDate
                )
                VALUES (
                    @Id,
                    CONVERT(uniqueidentifier, (SELECT Id from dbo.Products WHERE Id = @ProductId)),
                    @StartReservationDate,
                    @EndReservationDate
                )";

            var result = con.Execute(insertQuery, new
            {
                Id = reservationQuery.Id,
                ProductId = reservationQuery.ProductId,
                StartReservationDate = reservationQuery.StartReservationDate,
                EndReservationDate = reservationQuery.EndReservationDate,
            });


            return result;
        }

        public DateTime? IsReserveUntil(Guid productId, DateTime date)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();


            var reservationDate = con.QueryFirst<DateTime>(
              "SELECT EndReservationDate FROM dbo.Reservations " +
              "WHERE ProductId = @ProductId " +
              "AND EndReservationDate >= @date " +
              "ORDER BY EndReservationDate "
              , new
              {
                  ProductId = productId,
                  Date = date
              });

            return reservationDate;
        }
    }
}

