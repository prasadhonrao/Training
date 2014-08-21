using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var conversation = (StringProcessor) Delegate.Combine(new[] { prasadSays, rajveerSays });
            conversation("Hello");
            
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
}
