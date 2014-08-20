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

            // Below instantiation of ConcreteRegularPolygon can be confusing since its not a concrete shape

            //var polygon = new ConcreteRegularPolygon(10, 4);
            //Console.WriteLine("Concrete regular polygon perimeter is {0}", polygon.GetPerimeter());
            //Console.WriteLine("Concrete regular polygon area is {0}", polygon.GetArea());
            //Console.WriteLine();

            Console.WriteLine("Press [Enter] to terminate the program.");
            Console.ReadLine();
        }
    }
}
