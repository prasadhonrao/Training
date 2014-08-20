using System;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Save();

            ISaveable s = person;
            s.Save();
            // note Load method is not available on interface instance

            IPersistable p = (IPersistable) person;
            Console.WriteLine(p.Save());
            Console.WriteLine(p.Load());
            // note Load method is not available on interface instance

            Console.ReadLine();
        }
    }
}
