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

            //the number of reviews
            // average user rating for each product

            var product = con.Query<Product>(
              "SELECT \n" +
              "    dbo.Products.Id,\n" +
              "    dbo.Products.Name,\n" +
              "    dbo.Products.MainImageUrl,\n" +
              "    dbo.Products.Price,\n" +
              "    AVG(dbo.Reviews.Rating) AS Rating\n" +
              "    FROM dbo.Products\n" +
              "    FULL JOIN dbo.Reviews\n" +
              "    ON dbo.Products.Id = dbo.Reviews.ProductId\n" +
              "    WHERE dbo.Products.Id = @id \n" +
              "    GROUP BY \n" +
              "        dbo.Products.Id, \n" +
              "        dbo.Products.Name,\n" +
              "        dbo.Products.MainImageUrl,\n" +
              "        dbo.Products.Price" , new { id = id });

            return product;
        }

        public List<Product> GetAllProducts()
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            var products = con.Query<Product>(
                "SELECT \n" +
                "    dbo.Products.Id,\n" +
                "    dbo.Products.Name,\n" +
                "    dbo.Products.MainImageUrl,\n" +
                "    dbo.Products.Price,\n" +
                "    AVG(dbo.Reviews.Rating) AS Rating\n" +
                "    FROM dbo.Products\n" +
                "    FULL JOIN dbo.Reviews\n" +
                "    ON dbo.Products.Id = dbo.Reviews.ProductId\n" +
                "    GROUP BY \n" +
                "        dbo.Products.Id, \n" +
                "        dbo.Products.Name,\n" +
                "        dbo.Products.MainImageUrl,\n" +
                "        dbo.Products.Price")
                .ToList();

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

            // todo
            //System.Exception: Microsoft.Data.SqlClient.SqlException(0x80131904): Incorrect syntax near the keyword 'LIKE'.
            // Unclosed quotation mark after the character string '%@searchPhrase%'.

            // modify that query

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

