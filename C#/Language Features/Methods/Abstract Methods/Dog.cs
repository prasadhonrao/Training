using System;

namespace Training.CSharp
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            this.Name = name;
        }

        public override void PerformTricks()
        {
            Console.WriteLine("{0} is performing some tricks...", this.Name);
        }
    }
}
