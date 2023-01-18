using System;
using DotnetCourse.Interfaces;

namespace DotnetCourse.Queries
{
	public class ProductQueries : IProductQueries
	{

        public IConfiguration _configuration;

        public ProductQueries(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetProduct(Guid id)
        {
            var connectionString = _configuration["ConnectionStrings:DBConnection"];

            if (connectionString != null)
                return connectionString;

            return "No Connection String";

        }

	}
}

