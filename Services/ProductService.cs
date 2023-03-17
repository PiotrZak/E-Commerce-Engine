﻿using System;
using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;
using DotnetCourse.Utils;
using System.Text.Json;

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
            return product;
        }

        public ProductDetailsViewModel GetProductDetails(Guid id)
        {
            //ProductDetailsQueryModel
            var product = _productQueries.GetProductDetails(id);

            var productDetailsDict = JsonSerializer.Deserialize<Dictionary<string, string>>(product.ProductDetails ?? "");

            var productsViewModel = new ProductDetailsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                MainImageUrl = product.MainImageUrl,
                ImageUrls = product.ImageUrls,
                PreciseLocation = product.PreciseLocation,
                Price = product.Price,
                ProductDetails = productDetailsDict,
            };

            return productsViewModel;
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

        public List<ProductListViewModel> GetListProduct()
        {
            var products = _productQueries.GetListProducts();
            return products;
        }
    }
}

