using System;

//global class
class Configuration {}

namespace Global.Namespace.Alias
{
    // local class to namespace
    class Configuration { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Configuration));
            Console.WriteLine(typeof(global::Configuration));
            Console.WriteLine(typeof(global::Global.Namespace.Alias.Configuration)); // Nested class can still be accessed using global identifier
            Console.ReadLine();
        }
    }
}
