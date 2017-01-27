using System;
using System.Collections.Generic;

namespace Generic.Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var hat = new MagicHat<Animal>();

            var cat = new Animal() { Name = "Muffy" };
            var dog = new Animal() { Name = "Tuffy" };
            var snake = new Animal() { Name = "Anaconda" };

            hat.Put(cat);
            hat.Put(dog);
            hat.Put(snake);

            hat.Put(new[] { cat, dog, snake });

            Console.WriteLine("There are {0} items in the hat", hat.Count);
            Console.WriteLine(hat.Pull().Name);
            Console.WriteLine("There are {0} items left in the hat", hat.Count);
            Console.ReadLine();
        }
    }

    class MagicHat<T>
    {
        readonly Queue<T> _queue;

        public MagicHat()
        {
            _queue = new Queue<T>();
        }

        public void Put(T newItem)
        {
            _queue.Enqueue(newItem);
        }

        public void Put(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                _queue.Enqueue(item);
            }
        }

        public T Pull()
        {
            return _queue.Dequeue();
        }

        public int Count
        {
            get
            {
                return _queue.Count;
            }
        }
    }

    class Animal
    {
        public string Name { get; set; }
    }

}
