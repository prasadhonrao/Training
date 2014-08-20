using System;
namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog("puppy");
            animal.PerformTricks();
            animal.Run();

            Dog tuffy = new Dog("tuffy");
            tuffy.PerformTricks();
            tuffy.Run();

            Console.ReadLine();
        }
    }
}
