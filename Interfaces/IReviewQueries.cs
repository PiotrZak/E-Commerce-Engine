
using System;
using DotnetCourse.Models;

namespace DotnetCourse.Interfaces
{
    public interface IReviewQueries
    {
        int InsertReview(ReviewQuery reviewQuery);
    }
}
