using System;
using System.Runtime.ConstrainedExecution;
using Dapper;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using Microsoft.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;

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

            var sql = "SELECT * FROM dbo.Products";

            var location = filteredProduct.Location;
            var priceFrom = filteredProduct.PriceFrom;
            var priceTo = filteredProduct.PriceTo;
            var rating = filteredProduct.Rating;

            var filteredParameters = new { };

            if (location != null || priceFrom != null || priceTo != null || rating != null)
            {
                sql += "WHERE";
            }

            if (location != null)
            {
                sql += "AND Location = @location";
            }


            if (priceFrom != null)
            {
                sql += "AND Price > @PriceFrom";
            }


            if (priceTo != null)
            {
                sql += "AND Price < @PriceTo";
            }


            if (rating != null)
            {
                sql += "AND Rating = @Rating";
            }


            // Incorrect syntax exception
            var products = con.Query<Product>(sql, filteredParameters).ToList();

            return products;
        }

        public List<Product> GetSearchProducts(string searchPhrase)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            var sql = "SELECT * FROM dbo.ProductsWHERE Name LIKE '%@searchPhrase%' OR Location LIKE '%@searchPhrase%";

            var parameter = new
            {
                SearchPhrase = searchPhrase
            };

            var products = con.Query<Product>(sql, parameter).ToList();

            return products;
        }
    }
}

