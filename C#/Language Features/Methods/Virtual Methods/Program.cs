using System;
namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog tuffy = new Dog() { Name = "tuffy" };
            tuffy.PerformTricks();

            Animal ana = new Dog() { Name = "muffy" };
            ana.PerformTricks();

            Cat liccy = new Cat() { Name = "liccy" };
            liccy.PerformTricks();

            Console.ReadLine();
        }
    }
}
