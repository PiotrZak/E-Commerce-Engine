using System;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;

namespace DotnetCourse.Interfaces
{

    public interface IProductService
    {

        // Get one product
        ProductMainViewModel GetProduct(Guid id);

        // Get products for list
        List<ProductListViewModel> GetProductList();

        //// Get all products
        //List<Product> GetAllProducts();

        // Get filtered products
        List<Product> GetFilteredProducts(ProductFilters filteredProduct);

        // Get searched products
        List<Product> GetSearchProducts(string searchPhrase);

    }

}

