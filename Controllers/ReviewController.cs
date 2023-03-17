using DotnetCourse.Interfaces;
using DotnetCourse.Models;
using Microsoft.AspNetCore.Mvc;
namespace DotnetCourse.Controllers;

[ApiController]
[Route("[controller]")]
public class ReviewController : ControllerBase
{
    private readonly IReviewQueries _reviewService;

    public ReviewController(IReviewQueries reviewService)
    {
        _reviewService = reviewService;
    }

    [HttpPost("Review")]
    public int ReviewProduct(ReviewQuery reviewQuery)
    {
        try
        {

            if (reviewQuery.Rating < 1)
            {
                throw new Exception("Rating cannot be lower than 1");
            };

            if (reviewQuery.Rating > 5)
            {
                throw new Exception("Rating cannot be above than 5");
            };

            //To do
            //if (reviewQuery.ProductId)
            //{
            //    throw new Exception("This product don't exist it cannot be rated");
            //};

            var data = _reviewService.InsertReview(reviewQuery);
            return data;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.ToString());
        }
    }
}


