using System;

namespace Training.CSharp
{
    public class Dog : Animal
    {
        public override void PerformTricks()
        {
            Console.WriteLine("{0} dog is performing special tricks - BHO :-)", this.Name);
        }
    }
}
