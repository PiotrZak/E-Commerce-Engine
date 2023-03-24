namespace DotnetCourse.Models
{
    public enum SortProperty
    {
        ByPopularity,
        ByHighestPrice,
        ByLowestPrice,
    }

    public class ProductFilters
    {
        public string? Location { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        //todo - rating should be done via joining
        public int? Rating { get; set; }
        public SortProperty? SortBy { get; set; }
    }
}

