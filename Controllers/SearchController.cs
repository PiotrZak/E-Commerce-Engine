using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using DotnetCourse.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace DotnetCourse.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{

    private readonly IProductService _productService;

    public SearchController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("Search")]
    public List<SearchViewModel> SearchProduct(string searchPhrase)
    {
        try
        {
            var data = _productService.GetSearchProducts(searchPhrase);
            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }

    [HttpPost("Filter")]
    public List<Product> FilterProducts(ProductFilters productFilters)
    {

        try
        {
            var data = _productService.GetFilteredProducts(productFilters);
            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }

}


