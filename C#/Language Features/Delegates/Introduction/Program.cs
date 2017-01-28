using System;

namespace Training.CSharp
{
    class Program
    {
        delegate void StringProcessor(string message);

        static void Main(string[] args)
        {
            var prasad = new Person("Prasad");
            var rajveer = new Person("Rajveer");

            var prasadSays = new StringProcessor(prasad.Say);  // instance method
            var rajveerSays = new StringProcessor(rajveer.Say); // instance method
            var background = new StringProcessor(StaticMethods.Say); // static method

            prasadSays.Invoke("Look son, it's an aeroplane"); // calling instance method using Invoke
            rajveerSays("Ohh yes!"); // syntactic sugar i.e. without Invoke

            background("An aeroplane flies past."); // static method [can be called with/without invoke]

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public void Say(string message)
        {
            Console.WriteLine("{0} says: {1}", this.Name, message);
        }
    }

    public static class StaticMethods
    {
        public static void Say(string message)
        {
            Console.WriteLine("( {0} )", message);
        }
    }

}
