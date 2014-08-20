using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessage(DateTime.Now, "Prasad", true);
            SendMessage(DateTime.Now);
            Console.ReadLine();
        }

        public static void SendMessage(DateTime date, string userName = "Default User", bool isUpperCase = false)
        {
            if (isUpperCase)
                Console.WriteLine("HELLO {0}. THE TIME IS {1}", userName.ToUpper(), date.ToLongTimeString());
            else
                Console.WriteLine("Hello {0}. The time is {1}", userName, date.ToLongTimeString());
        }
    }

}
