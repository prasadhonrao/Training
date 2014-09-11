using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dictionary.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basic example
            
            var numberDictionary = new Dictionary<int, string>();
            numberDictionary.Add(1, "One");
            numberDictionary.Add(2, "Two");
            numberDictionary.Add(3, "Three");

            Console.WriteLine("Number of items in Dictionary {0}", numberDictionary.Count);

            Console.WriteLine("Dictionary contents");
            foreach (var item in numberDictionary)
            {
                Console.WriteLine("Key:{0} Value:{1}", item.Key, item.Value);
            }

            Console.WriteLine("Removing item from dictionary");
            numberDictionary.Remove(1);
            Console.WriteLine("Dictionary contents");
            foreach (var item in numberDictionary)
            {
                Console.WriteLine("Key:{0} Value:{1}", item.Key, item.Value);
            }

            Console.WriteLine();
            
            #endregion

            #region Word count example

            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";


            Dictionary<string, int> frequencies = CountWords(text);
            
            foreach (KeyValuePair<string,int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0} : {1}", word, frequency);
            }

            #endregion

            Console.WriteLine("----");
        }

        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            string[] words = Regex.Split(text, @"\W+");

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word] = frequencies[word] + 1;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }
            return frequencies;
        }
    }
}
