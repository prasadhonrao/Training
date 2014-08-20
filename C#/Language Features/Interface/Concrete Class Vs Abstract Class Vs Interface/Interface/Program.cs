using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareLength = 10;
            var sqaure = new Square(squareLength);
            Console.WriteLine("Square side length is {0}", squareLength);
            Console.WriteLine("Square perimeter is {0}", sqaure.GetPerimeter());
            Console.WriteLine("Square area is {0}", sqaure.GetArea());
            Console.WriteLine();

            var triangleLength = 10;
            var triangle = new Triangle(triangleLength);
            Console.WriteLine("Triangle side length is {0}", triangleLength);
            Console.WriteLine("Triangle perimeter is {0}", triangle.GetPerimeter());
            Console.WriteLine("Triangle area is {0}", triangle.GetArea());
            Console.WriteLine();

            var octagonLength = 10;
            var octagon = new Octagon(octagonLength);
            Console.WriteLine("Octagon side length is {0}", octagonLength);
            Console.WriteLine("Octagon perimeter is {0}", octagon.GetPerimeter());
            Console.WriteLine("Octagon area is {0}", octagon.GetArea());
            Console.WriteLine();

            Console.WriteLine("Press [Enter] to terminate the program.");
            Console.ReadLine();
        }
    }
}
