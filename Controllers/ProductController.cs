using Microsoft.AspNetCore.Mvc;
using DotnetCourse.Models;
namespace DotnetCourse.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
  
    [HttpGet("GetProduct")]
    public Product GetProductDetails()
    {
        var product = new Product("Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);
        return product;
    }

    [HttpGet("GetProducts")]
    public List<Product> GetProducts()
    {
        var a = new Product("Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);
        var b = new Product("Emeralda De Hotel", "Paris, Amsterdam", 29, 4.8);

        var products = new List<Product>
        {
            a, b
        };

        return products;
    }
}
