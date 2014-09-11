using System;
using System.Collections.Generic;

namespace List.Size.Resize.Pattern
{
    class Program
    {
        static void Main()
        {
            int capacity = -1;
            var numbers = new List<int>();

            //List<int> numbers = new List<int>(10); // doubling start from 10

            while (true)
            {
                if (numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(capacity);
                }

                numbers.Add(1);
            }
        }
    }
}
