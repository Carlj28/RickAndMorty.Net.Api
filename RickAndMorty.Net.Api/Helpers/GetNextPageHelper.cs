using System;
using System.Text.RegularExpressions;

namespace RickAndMorty.Net.Api.Helpers
{
    internal static class GetNextPageHelper
    {
        static readonly Regex PagePattern = new Regex("page=(?<pagenr>[0-9]+)");

        public static int GetNextPageNumber(this string url)
        {
            if (String.IsNullOrEmpty(url))
                return -1;

            var result = PagePattern.Match(url).Groups["pagenr"].Value;

            if (String.IsNullOrEmpty(result))
                return -1;

            return Convert.ToInt32(result);
        }
    }
}
