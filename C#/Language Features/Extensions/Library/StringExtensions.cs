using System;
using System.Collections.Generic;
using System.Linq;
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
        public static int Occurrence(this String input, string search)
        {
            return Regex.Matches(input, search).Count;
        }

        public static int CountWords(this string input)
        {
            if (input.Trim().Length == 0)
                return 0;

            return Regex.Split(input, @"\W+").Length;
        }

        public static int CountUniqueWords(this string input)
        {
            var words = Regex.Split(input, @"\W+");
            var unique = words.ToList().Distinct();
            return unique.Count();
        }

        public static int CountCharactersWithoutSpace(this string input)
        {
            int characterCount = 0;
            string[] words = input.Split(' ');
            words.ToList().ForEach(w => characterCount += w.Length);
            return characterCount;
        }

        public static bool IsAllUpper(this string input)
        {
            char[] chars = input.ToCharArray();
            return chars.All(c => (char.IsUpper(c) || char.IsWhiteSpace(c)));
        }

        public static bool IsAllLower(this string input)
        {
            char[] chars = input.ToCharArray();
            return chars.All(c => (char.IsLower(c) || char.IsWhiteSpace(c)));
        }

        // Upper case first letter
        public static string ToTitleCase(this string input)
        {
            if (input.Length > 0)
            {
                char[] array = input.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return input;
        }
    }
}
