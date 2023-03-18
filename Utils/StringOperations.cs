using System;
namespace DotnetCourse.Utils
{
	public class StringOperations
	{
        public static string GetCountryAndCity(string location)
        {
            int count = location.IndexOf(",", location.IndexOf("," + 1));
            string country = location.Substring(0, count).Trim();
            string city = location.Substring(count + 1).Trim();
            return country + ", " + city;
        }
    }
}

