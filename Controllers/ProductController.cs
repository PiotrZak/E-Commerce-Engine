using Microsoft.AspNetCore.Mvc;
using DotnetCourse.Models;
using DotnetCourse.Interfaces;
using DotnetCourse.Services;
using DotnetCourse.ViewModels;

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

    [HttpGet("GetProductMain")]
    public ProductMainViewModel GetProductMain(Guid id)
    {
        try
        {
            if (String.IsNullOrEmpty(id.ToString()))
            {
                throw new Exception("Id is empty");
            };

            var data = _productService.GetProductMain(id);

            if (data == null)
            {
                throw new Exception("There isn't products for this id");
            };

            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }


    [HttpGet("GetProductDetails")]
    public ProductDetailsViewModel GetProductDetails(Guid id)
    {
        try
        {
            if (String.IsNullOrEmpty(id.ToString()))
            {
                throw new Exception("Id is empty");
            };

            var data = _productService.GetProductDetails(id);

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

    [HttpGet("GetListProducts")]
    public List<ProductListViewModel> GetProductsList()
    {
        try
        {
            var data = _productService.GetListProduct();
            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }
}
