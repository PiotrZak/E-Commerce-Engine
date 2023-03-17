using System;
using System.Runtime.ConstrainedExecution;
using Dapper;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using Microsoft.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace DotnetCourse.Queries
{
    public class ProductQueries : IProductQueries
    {

        public IConfiguration _configuration;

        public ProductQueries(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Product GetProduct(Guid id)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            var product = con.QueryFirst<Product>("SELECT * FROM dbo.Products WHERE id=@id",
                new { id = id });

            return product;
        }

        public List<Product> GetAllProducts()
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            var products = con.Query<Product>("SELECT * FROM dbo.Products").ToList();

            return products;
        }

        public List<Product> GetFilteredProducts(ProductFilters filteredProduct)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            var sql = "SELECT * FROM dbo.Products ";

            var filteredParameters = new DynamicParameters();

            if (filteredProduct.Location != null || filteredProduct.PriceFrom != null || filteredProduct.PriceTo != null || filteredProduct.Rating != null)
            {
                sql += "WHERE Id IS NOT NULL ";
            }

            if (filteredProduct.Location != null)
            {
                sql += "AND Location = @location ";
                filteredParameters.Add("location", filteredProduct.Location);
            }


            if (filteredProduct.PriceFrom != null)
            {
                sql += "AND Price > @PriceFrom ";
                filteredParameters.Add("PriceFrom", filteredProduct.PriceFrom);
            }


            if (filteredProduct.PriceTo != null)
            {
                sql += "AND Price < @PriceTo ";
                filteredParameters.Add("PriceTo", filteredProduct.PriceTo);
            }


            if (filteredProduct.Rating != null)
            {
                sql += "AND Rating = @Rating ";
                filteredParameters.Add("Rating", filteredProduct.Rating);
            }

            var products = con.Query<Product>(sql, filteredParameters).ToList();

            return products;
        }

        public List<Product> GetSearchProducts(string searchPhrase)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            var sql = "SELECT * FROM dbo.Products WHERE Name LIKE @searchPhrase OR Location LIKE @searchPhrase";
            var products = con.Query<Product>(sql, new { searchPhrase = "%" + searchPhrase + "%"}).ToList();

            return products;
        }
    }
}

