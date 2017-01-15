using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountWordsInText
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @"Twinkle twinkle little star
                         How I wonder what you are
                         Up above the world so high
                         Like a diamond in the sky";

            var words = CountWords(text);

            foreach (var item in words)
            {
                string word = item.Key;
                int frequency = item.Value;
                Console.WriteLine("{0} : {1}", word, frequency);
            }

            Console.ReadLine();
        }

        static Dictionary<string, int> CountWords(string text)
        {
            var frequencies = new Dictionary<string, int>();

            var words = Regex.Split(text, @"\W+");

            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                    frequencies[word] = frequencies[word] + 1;
                else
                    frequencies[word] = 1;
            }

            return frequencies;
        }

     
    }
}
