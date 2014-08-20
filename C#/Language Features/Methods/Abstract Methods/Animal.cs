using System;
namespace Training.CSharp
{
    public abstract class Animal
    {
        public abstract void PerformTricks();

        public string Name { get; set; }

        public void Run()
        {
            Console.WriteLine("{0} is running...", this.Name);
        }
    }
}
