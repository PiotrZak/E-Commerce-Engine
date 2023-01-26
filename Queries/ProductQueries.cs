using System;
using System.Runtime.ConstrainedExecution;
using Dapper;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using Microsoft.Data.SqlClient;

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

            // WHERE Location
            // Where PriceFrom > AND PriceTo <
            // WHERE Rating > AND RATING < 5

            var products = con.Query<Product>("SELECT * FROM dbo.Products").ToList();

            return products;
        }

        public List<Product> GetSearchProducts(string searchPhrase)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            using var con = new SqlConnection(connectionString);
            con.Open();

            // Get all products with specific phrase in name or location

            var products = con.Query<Product>("SELECT * FROM dbo.Products").ToList();

            return products;
        }
    }
}

