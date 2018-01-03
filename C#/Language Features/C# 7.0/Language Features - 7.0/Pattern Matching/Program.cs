using static System.Console;

namespace Pattern_Matching
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSum(10);
            PrintSum2("10");
            ReadLine();
        }

        static void PrintSum(object input)
        {
            if (input is null) return; // constant pattern

            if (!(input is int i)) return; // type pattern (int)

            int sum = 0;

            for (int j = 0; j <= i; j++)
            {
                sum += j;
            }

            WriteLine($"Sum of 1 to {i} is {sum}");
        }

        static void PrintSum2(object input)
        {
            if (input is null) return; // constant pattern

            if (input is int i || input is string s && int.TryParse(s, out i)) // type pattern
            {
                int sum = 0;

                for (int j = 0; j <= i; j++)
                {
                    sum += j;
                }
                WriteLine($"Sum of 1 to {i} is {sum}");

            }
        }
    }
}
