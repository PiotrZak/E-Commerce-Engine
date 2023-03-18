using System;
using System.Globalization;

namespace DotnetCourse.Utils
{
    public static class UserCurrency
    {
        public static string GetCurrency()
        {
            return CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
        }
    }
}

