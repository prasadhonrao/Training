using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessage(DateTime.Now, userName: "Prasad");
            SendMessage(DateTime.Now, isUpperCase: true, userName: "Scott");

            Method();
            Method(1);
            Method(message: "New message");
            Method(number: GetNumber());
            Method(message: GetMessage());

            Method(number: GetNumber(), message: GetMessage()); // GetNumber will be called first
            Method(message: GetMessage(), number: GetNumber()); // GetMessage will be called first

            Console.ReadLine();
        }

        public static void SendMessage(DateTime date, string userName = "Default User", bool isUpperCase = false)
        {
            if (isUpperCase)
                Console.WriteLine("HELLO {0}. THE TIME IS {1}", userName.ToUpper(), date.ToLongTimeString());
            else
                Console.WriteLine("Hello {0}. The time is {1}", userName, date.ToLongTimeString());
        }

        static void Method(int number = 0, string message = "")
        {
            Console.WriteLine("Number {0} Message {1}", number, message);
        }

        static int GetNumber()
        {
            Console.WriteLine("Getting number");
            return 10;
        }

        static string GetMessage()
        {
            Console.WriteLine("Getting message");
            return "This is a mesage";
        }
    }
}
