using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string userName = Console.ReadLine();

            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good morning {0}", userName);
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 17)
            {
                Console.WriteLine("Good afternoon {0}", userName);
            }
            else
            {
                Console.WriteLine("{0}, you're working odd hours", userName);
            }

            Console.WriteLine(Environment.ProcessorCount);
            var is64BitOs = Environment.Is64BitOperatingSystem ? "Yes" : "No"; 
            Console.WriteLine("Is 64 bit operating system {0}", is64BitOs);

            Console.ReadLine();
        }
    }
}
