using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public static class StringUtility
    {
        public static string DancingLetters(this string input)
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
