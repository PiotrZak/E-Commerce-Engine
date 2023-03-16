
using System;
using Dapper;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;
using Microsoft.Data.SqlClient;

namespace DotnetCourse.Queries
{
	public class ReviewQueries : IReviewQueries
    { 
        public IConfiguration _configuration;

        public ReviewQueries(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int InsertReview(ReviewQuery reviewQuery)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();


            string insertQuery = @"INSERT INTO dbo.Reviews
                (
                    Id,
                    UserId,
                    ProductId,
                    ReviewDate,
                    Rating
                )
                VALUES (
                    @Id,
                    CONVERT(uniqueidentifier, @UserId),
                    CONVERT(uniqueidentifier, (SELECT Id from dbo.Products WHERE Id = @ProductId)),
                    @ReviewDate,
                    @Rating
                )";

            var result = con.Execute(insertQuery, new
            {
                Id = Guid.NewGuid(),
                UserId = reviewQuery.UserId,
                ProductId = reviewQuery.ProductId,
                ReviewDate = DateTime.UtcNow,
                Rating = reviewQuery.Rating
            });


            return result;
        }
    }
}

