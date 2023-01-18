using System;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;

namespace DotnetCourse.Services
{
	public class ProductService : IProductService
	{
		public ProductService()
		{
		}

        //Queries
        public List<Product> GetAllProducts()
        {
            var a = new Product(new Guid(), "Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);
            var b = new Product(new Guid(), "Novotel", "Warsaw, Amsterdam", 29, 4.8);

            var products = new List<Product>
            {
                a, b
            };

            return products;
        }

        public List<Product> GetFilteredProducts(ProductFilters filteredProduct)
        {
            var a = new Product(new Guid(), "Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);
            var b = new Product(new Guid(), "Novotel", "Warsaw, Amsterdam", 29, 4.8);

            var products = new List<Product>
            {
                a, b
            };

            return products;
        }

        public Product GetProduct(Guid id)
        {


     
            var product = new Product(new Guid(), "Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);

            // execute Query -> connect to database 
            return product;
        }

        public List<Product> GetSearchProducts(string searchPhrase)
        {
            var a = new Product(new Guid(), "Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);
            var b = new Product(new Guid(), "Novotel", "Warsaw, Amsterdam", 29, 4.8);

            var products = new List<Product>
            {
                a, b
            };

            var findProduct = products.Find(x => x.Name.Contains(searchPhrase));
            var matchingProducts = new List<Product>
            {
                findProduct ?? new Product(new Guid(), "Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8)
            };

            return matchingProducts;

        }
    }
}

