using System;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;

namespace DotnetCourse.Interfaces
{

    public interface IProductService
    {

        // Get one product
        ProductMainViewModel GetProductMain(Guid id);

        // Get products for list
        List<ProductListViewModel> GetListProduct();

        // Get filtered products
        List<Product> GetFilteredProducts(ProductFilters filteredProduct);

        // Get searched products
        List<Product> GetSearchProducts(string searchPhrase);

        // Get Product Details
        ProductDetailsViewModel GetProductDetails(Guid id);
    }

}

