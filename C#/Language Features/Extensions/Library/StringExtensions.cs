using System;
using System.Text.RegularExpressions;

namespace Extensions.Library
{
    public static class StringExtensions
    {
        // Usage: var count = strCount.ToInt();
        public static int ToInt(this String input)
        {
            int result;
            if (!int.TryParse(input, out result))
            {
                result = 0;
            }
            return result;
        }


        // Usage: var count = "supercalifragilisticexpealidocious".Occurrence("li"); // returns 3
        public static int Occurrence(this String instr, string search)
        {
            return Regex.Matches(instr, search).Count;
        }
    }
}
