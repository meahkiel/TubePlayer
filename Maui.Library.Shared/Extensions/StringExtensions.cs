using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Maui.Library.Shared.Extensions
{
    public static class StringExtensions
    {
        public static string CleanCacheKey(this string uri) =>
        Regex.Replace((new Regex("[\\~#%&*{}/:<>?|\"-]")).Replace(uri, " "), @"\s+", "_");

        public static string FormattedNumber(this string number) 
            => Convert.ToDouble(number).FormattedNumber();
    }
}
