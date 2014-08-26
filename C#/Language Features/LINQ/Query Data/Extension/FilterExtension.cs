using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public static class FilterExtension
    {
        public static IEnumerable<string> FormatStringWithAlternateCap(this IEnumerable<string> collection)
        {
            foreach (string item in collection)
            {
                yield return FormatString(item);
            }
        }

        private static string FormatString(string input)
        {
            string result = "";
            char[] charArray = input.ToLower().ToCharArray();

            for (int ctr = 0; ctr < charArray.Length; ctr++)
            {
                if (ctr % 2 == 0)
                {
                    result += charArray[ctr].ToString().ToUpper();
                }
                else
                {
                    result += charArray[ctr].ToString();
                }
            }

            return result;
        }
    }
}
