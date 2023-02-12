using System;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;

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

        public List<SearchViewModel> GetSearchProducts(string searchPhrase)
        {
            var products = _productQueries.GetSearchProducts(searchPhrase);

            var searchViewModel = products.Select(x => new SearchViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return searchViewModel;

        }
    }
}

