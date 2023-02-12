using System;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;

namespace DotnetCourse.Interfaces
{

    public interface IProductService
    {

        // Get one product
        Product GetProduct(Guid id);

        // Get all products
        List<Product> GetAllProducts();

        // Get filtered products
        List<Product> GetFilteredProducts(ProductFilters filteredProduct);

        // Get searched products
        List<SearchViewModel> GetSearchProducts(string searchPhrase);

    }

}

