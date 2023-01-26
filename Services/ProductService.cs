using System;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;

namespace DotnetCourse.Services
{
	public class ProductService : IProductService
	{
        public IProductQueries _productQueries;

        public ProductService(IProductQueries productQueries)
        {
            _productQueries = productQueries;
        }


        public Product GetProduct(Guid id)
        {
            var product = _productQueries.GetProduct(id);
            return product;
        }


        public List<Product> GetAllProducts()
        {
            var products = _productQueries.GetAllProducts();
            return products;
        }

        public List<Product> GetFilteredProducts(ProductFilters filteredProduct)
        {
            var products = _productQueries.GetFilteredProducts(filteredProduct);
            return products;
        }

        public List<Product> GetSearchProducts(string searchPhrase)
        {
            var products = _productQueries.GetSearchProducts(searchPhrase);
            return products;

        }
    }
}

