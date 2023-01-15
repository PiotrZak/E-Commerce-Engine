using DotnetCourse.Models;
using Microsoft.AspNetCore.Mvc;
namespace DotnetCourse.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
    [HttpGet("Search")]
    public List<Product> SearchProduct(string searchPhrase)
    {
        var a = new Product("Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);
        var b = new Product("Novotel", "Warsaw, Amsterdam", 29, 4.8);

        var products = new List<Product>
        {
            a, b
        };

        var findProduct = products.Find(x => x.Name.Contains(searchPhrase));
        var matchingProduct = new List<Product>
        {
            findProduct ?? new Product("Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8)
        };

        return matchingProduct;
    }

    [HttpPost("Filter")]
    public ProductFilters FilterProducts(ProductFilters productFilters)
    {
        return productFilters;
    }

}


