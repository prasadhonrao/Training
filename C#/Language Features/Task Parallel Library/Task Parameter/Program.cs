using System;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew((arg) =>
                {
                    int id = (int)arg;
                    Console.WriteLine(id);
                }, i);
            }

            Console.Read();
        }
    }
}
