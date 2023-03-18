using System;
namespace DotnetCourse.Utils
{
	public class StringOperations
	{
        public static string GetCountryAndCity(string location)
        {
            string[] parts = location.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                return location.Trim(); // Return original location string if less than 2 parts found
            }

            return String.Join(",", parts.Take(2)).Trim();
        }
    }
}

