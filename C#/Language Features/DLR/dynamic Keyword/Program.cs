using System;

namespace Training.CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = "Hello World!";
            Console.WriteLine("Text length is {0}", text.Length);

            dynamic content = "Hello World!";
            Console.WriteLine("Content length is {0}", content.Length);

            content = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Content length is {0}", content.Length);

            Console.ReadLine();
        }
    }
}
