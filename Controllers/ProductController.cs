using Microsoft.AspNetCore.Mvc;

namespace Desktop.Controllers;

public class Product
{
    public string Name { get; set; }
}

[ApiController]
[Route("[controller]")]

//private
//protected
public class ProductController : ControllerBase
{

    [HttpGet(Name = "GetProduct")]
    public Product Get()
    {

        var product = new Product
        {
            Name = "Hotel A",
        };

        var products = new List<Product>
        {
            new Product
            {
                Name = "Hotel A"
            },
            new Product
            {
                Name = "Hotel B"
            }
        };

        return product;
    }
}
