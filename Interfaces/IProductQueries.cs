﻿using System;
using DotnetCourse.Models;

namespace DotnetCourse.Interfaces
{
	public interface IProductQueries
	{
        Product GetProduct(Guid id);
        List<Product> GetAllProducts();
        List<Product> GetFilteredProducts(ProductFilters filteredProduct);
        List<Product> GetSearchProducts(string searchPhrase);

    }
}

