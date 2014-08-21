using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 10, 20, 30, 40, 50, 60, 70 };

            foreach (var item in ages)
            {
                if (item == 30)
                {
                    Console.WriteLine("Continue" + item);
                    continue;
                }

                if (item == 60)
                {
                    Console.WriteLine("Break" + item);
                    break;
                }

                Console.WriteLine(item);
            }
        }
    }
}
