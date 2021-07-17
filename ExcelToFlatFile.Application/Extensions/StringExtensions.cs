using System;
using System.Linq;

namespace ExcelToFlatFile.Application.Extensions
{
    public static class StringExtensions
    {
        public static string ConvertToFormattedDateString(this string input, string format)
        {
            if (DateTime.TryParse(input, out DateTime date))
            {
                var outString = date.ToString(format);
                return outString;
            }

            return "";
        }

        public static string MultiplyStringByInt(this string input, int multiplyBy)
        {
            if (decimal.TryParse(input, out decimal result))
            {
                var multiplyResult = result * multiplyBy;
                return multiplyResult.ToString();
            }

            return "";
        }

        public static string SetToEmptyIfMatch(this string input, params string[] testStrings)
        {
            if (testStrings.Contains(input))
            {
                return "";
            }

            return input;
        }
    }
}