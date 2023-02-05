using Microsoft.AspNetCore.Mvc;
using DotnetCourse.Models;
using DotnetCourse.Interfaces;
using DotnetCourse.Services;

namespace DotnetCourse.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }


    [HttpGet("GetProduct")]
    public Product GetProductDetails(Guid id)
    {
        try
        {
            if (String.IsNullOrEmpty(id.ToString()))
            {
                throw new Exception("Id is empty");
            };

            var data = _productService.GetProduct(id);

            if (data == null)
            {
                throw new Exception("There isn't products for this id");
            };

            return data;
        }
        catch(Exception exception)
        {
            throw new Exception (exception.ToString());
        }
    }

    [HttpGet("GetProducts")]
    public List<Product> GetProducts()
    {
        try
        {
            var data = _productService.GetAllProducts();
            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }
}
