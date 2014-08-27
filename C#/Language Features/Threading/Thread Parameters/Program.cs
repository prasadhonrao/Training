using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            var T1 = new Thread(PrintMessage);  // static method
            T1.Start("Hello World");

            var m = new Messenger("Hello World Again!");
            var T2 = new Thread(m.DisplayMessage); // instance method
            T2.Start();

            Console.WriteLine("Ending Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        private static void PrintMessage(object obj)
        {
            string input = obj as string;
            Console.WriteLine(input);

            Console.WriteLine("Thread id is {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }


    public class Messenger
    {
        protected string message { get; private set; }

        public Messenger(string inputMessage)
        {
            this.message = inputMessage;
        }

        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }
    }
}
