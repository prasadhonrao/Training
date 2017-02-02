using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var prasad = new Person("Prasad Honrao", new DateTime(1979, 08, 01), null);
            var steve = new Person("Steve Jane", new DateTime(1960, 01, 01), new DateTime(2013, 04, 04));
            Console.WriteLine("Prasad's Age {0}", prasad.Age);
            Console.WriteLine("Steve's Age {0}", steve.Age);
            Console.ReadLine();
        }
    }

    class Person
    {
        DateTime birth;
        DateTime? death;
        string name;

        public Person(string name, DateTime birth, DateTime? death)
        {
            this.name = name;
            this.birth = birth;
            this.death = death;
        }

        public int Age
        {

            get
            {
                if (death == null)
                {
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    TimeSpan span = DateTime.Now - birth;
                    int years = (zeroTime + span).Year - 1;
                    return years;
                }
                else
                {
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    TimeSpan span = death.Value - birth;
                    int years = (zeroTime + span).Year - 1;
                    return years;
                }
            }
        }
    }
}
