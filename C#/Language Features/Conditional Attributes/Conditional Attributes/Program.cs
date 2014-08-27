using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            WriteMessage("Application is running in debug mode");
#elif RELEASE
                WriteMessage("App is running in release mode");
#else
                WriteMessage("Check the app mode");
#endif

#if CUSTOM
            Console.WriteLine("You have added CUSTOM compilation symbol");
#endif

            Console.ReadLine();
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
