using System.Collections.Generic;
using System.Linq;

namespace Training.CSharp
{
    public static class StringExtensions
    {
        public static List<string> ConvertStringToList(string commaSeparatedString)
        {
            string[] items = commaSeparatedString.Split(',');
            return items.ToList<string>();
        }

        public static List<string> SplitUsingComma(this string commaSeparatedString)
        {
            string[] items = commaSeparatedString.Split(',');
            return items.ToList<string>();
        }
    }
}
