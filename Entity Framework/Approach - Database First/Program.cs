using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approach___Database_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWEntities())
            {
                var people = context.People.Include("PersonPhones").Take(100);
                var counter = 1;
                foreach (var person in people)
                {
                    Console.WriteLine("{0} : {1} {2}, {3}", counter, person.FirstName, person.LastName, person.PersonPhones.First().PhoneNumber);
                    counter++;
                }
            }

            Console.WriteLine("Press [Enter] to quit...");
            Console.ReadLine();
        }
    }
}
