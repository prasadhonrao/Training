using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure commmand line arguments are passed
            if (args != null && args.Length > 0)
            {
                foreach (var item in args)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
