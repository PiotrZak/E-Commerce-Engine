using System;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.Utils;

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

            if (filteredProduct.SortBy == null)
            {
                return products;
            }

            var sortedProduct = new List<Product>();

            // Todo - Define popularity

            if (filteredProduct.SortBy == SortProperty.ByHighestPrice)
            {
                sortedProduct = products.OrderByDescending(x => x.Price).ToList();
            }

            if (filteredProduct.SortBy == SortProperty.ByLowestPrice)
            {
                sortedProduct = products.OrderBy(x => x.Price).ToList();
            }

            Validation.ValidateFromToPrice(filteredProduct.PriceFrom, filteredProduct.PriceTo);
            return products;
        }

        public List<Product> GetSearchProducts(string searchPhrase)
        {
            var products = _productQueries.GetSearchProducts(searchPhrase);
            return products;

        }
    }
}

