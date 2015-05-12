using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListResizePattern
{
    class Program
    {
        static void Main(string[] args)
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
