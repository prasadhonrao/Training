using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion.Type.Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            var MySaveableItems = new SaveableItems<BaseSaveable>();
            
            MySaveableItems.Add(new Book() { Name = "2 States" });
            MySaveableItems.Add(new Book() { Name = "Shivaji" });

            MySaveableItems.Add(new Product() { Name = "Surface Pro" });
            MySaveableItems.Add(new Product() { Name = "iPad" });

            MySaveableItems.PrintAllSavedItems();

            Console.ReadLine();
        }
    }

    public class SaveableItems<T> where T : class, ISaveable, new()
    {
        private readonly List<T> _saveables;

        public SaveableItems()
        {
            _saveables = new List<T>();
        }

        public void Add(T item)
        {
            _saveables.Add(item);
        }

        public void PrintAllSavedItems()
        {
            foreach (T item in _saveables)
            {
                item.Print();
            }
        }
    }

    public interface ISaveable 
    {
        void Print();
    }

    public class BaseSaveable : ISaveable
    {
        public virtual void Print() { }
        public string Name { get; set; }
    }

    public class Book : BaseSaveable, ISaveable
    {
        public override void Print()
        {
            Console.WriteLine("Book " + Name);
        }
    }

    public class Product : BaseSaveable, ISaveable
    {
        public override void Print()
        {
            Console.WriteLine("Product " + Name);
        }
    }
}
