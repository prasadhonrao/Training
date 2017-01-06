using System;

namespace Training.CSharp
{
    // delegate declaration	
    public delegate int AddDelegate(int x, int y);
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // Delegate with method reference
            AddDelegate addMethod = new AddDelegate(AddMethod);
            var result1 = addMethod(10, 20);
            Console.WriteLine("Delegate with method reference " + result1);

            // Delegate with lambda
            AddDelegate addLambda = (x, y) => x + y;
            int result2 = addLambda(10, 20);
            Console.WriteLine("Delegate with lambda " + result2);

            // Func
            Func<int, int, int> addFunc = (x, y) => { return x + y; };
            int result3 = addFunc(10, 20);
            Console.WriteLine("Func Delegate " + result3);

            Console.ReadLine();
        }

        private static int AddMethod(int x, int y)
        {
            return x + y;
        }
    }
}
