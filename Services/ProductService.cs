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

        public ProductMainViewModel GetMainProduct(Guid id)
        {
            var product = _productQueries.GetProductMain(id);
            return product;
        }

        public ProductDetailsViewModel GetProductDetails(Guid id)
        {
            var product = _productQueries.GetProductDetails(id);
            return product;
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

        public List<ProductListViewModel> GetProductList()
        {
            var products = _productQueries.GetListProducts();
            return products;
        }

        //public List<Product> GetAllProducts()
        //{
        //    var products = _productQueries.GetAllProducts();
        //    return products;
        //}
    }
}

