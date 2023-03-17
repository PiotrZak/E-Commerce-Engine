using System;
namespace DotnetCourse.Utils
{
	public class Validation
	{
		static public void ValidateFromToPrice(decimal? priceFrom, decimal? priceTo)
		{
			if (priceFrom > priceTo)
			{
				throw new Exception("Price from cannot be more than price to");
			}

			if (priceFrom == 0 || priceTo == 0)
			{
                throw new Exception("Price from cannot be more than price to");
            }
		}
	}
}

