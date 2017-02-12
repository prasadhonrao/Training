using System;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task parentTask = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Executing parent task");

                Task child1 = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Executing child task 1");
                }, TaskCreationOptions.AttachedToParent);

                Task child2 = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Executing child task 2");
                }, TaskCreationOptions.AttachedToParent);
            });

            Console.Read();
        }
    }
}
