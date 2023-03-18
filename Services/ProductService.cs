using System;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;
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

        public ProductMainViewModel GetProductMain(Guid id)
        {
            var product = _productQueries.GetProductMain(id);
            product.Location = StringOperations.GetCountryAndCity(product.Location);

            return product;
        }

        public List<ProductListViewModel> GetListProduct()
        {
            var products = _productQueries.GetListProducts();

            foreach(var product in products)
            {
                //bit complexity of the operation
                product.Location = StringOperations.GetCountryAndCity(product.Location);

            }
            return products;
        }

        public ProductDetailsViewModel GetProductDetails(Guid id)
        {
            var product = _productQueries.GetProductDetails(id);

            var currency = UserCurrency.GetCurrency();
            var productPrice = product.Price + currency;

            return product;
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

