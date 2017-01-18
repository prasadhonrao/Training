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

            #region Using HastTable / C# 1.0 Syntax which involves boxing and unboxing
            var words2 = CountWordsUsingNonGenericsHastTable(text);
            foreach (DictionaryEntry item in words2)
            {
                string word = (string)item.Key;
                int frequency = (int)item.Value;
                Console.WriteLine("{0} : {1}", word, frequency);
            }
            #endregion

            Console.WriteLine("**********");

            #region Using Generics
            var words = CountWordsUsingGenerics(text);
            foreach (var item in words)
            {
                string word = item.Key;
                int frequency = item.Value;
                Console.WriteLine("{0} : {1}", word, frequency);
            }
            #endregion


            Console.ReadLine();
        }

        static Dictionary<string, int> CountWordsUsingGenerics(string text)
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

        static Hashtable CountWordsUsingNonGenericsHastTable(string text)
        {
            var frequencies = new Hashtable();

            var words = Regex.Split(text, @"\W+");

            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                    frequencies[word] = (int)frequencies[word] + 1;
                else
                    frequencies[word] = 1;
            }

            return frequencies;
        }
    }
}
