using System;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;

namespace DotnetCourse.Interfaces
{
	public interface IProductQueries
	{
        ProductMainViewModel GetProductMain(Guid id);
        ProductDetailsQueryModel GetProductDetails(Guid id);
        List<ProductListViewModel> GetListProducts();
        List<Product> GetFilteredProducts(ProductFilters filteredProduct);
        List<Product> GetSearchProducts(string searchPhrase);

    }
}

