using System;
using System.Collections.Generic;

namespace Introduction
{
    class Program
    {
        static void Main()
        {
            #region Non Generic implementation
            var cat = new Animal("Mini");
            var dog = new Animal("Tuffy");

            var animals = new AnimalCollection();
            animals.Add(cat);
            animals.Add(dog);

            var firstAnimal = animals[0] as Animal;
            Console.WriteLine("Name of first animals is {0}", firstAnimal.Name);

            var pe = new Person("Prasad Honrao");

            // Adding person in Animal collection!
            animals.Add(pe);
            Console.WriteLine();

            var people = new PersonCollection();
            // Adding animals in Person collection!
            people.Add(cat);
            people.Add(dog);
            people.Add(pe);

            foreach (var item in people)
            {
                if (item is Person)
                {
                    Console.WriteLine(((Person)item).Name); // Explicit typecast is required
                }
                else
                {
                    Console.WriteLine("Animal {0} found in person collection", ((Animal)item).Name);
                }
            }
            #endregion

            #region Generic Implementation
            var onlyAnimals = new List<Animal>();
            onlyAnimals.Add(dog);
            onlyAnimals.Add(cat);

            // compile time error
            // onlyAnimals.Add(pe);

            var onlyPeople = new List<Person>();
            onlyPeople.Add(pe);

            // compile time error
            //onlyPeople.Add(dog);

            #endregion

            Console.ReadLine();
        }
    }
}
