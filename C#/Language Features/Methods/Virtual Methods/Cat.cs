using System;
namespace Training.CSharp
{
    public class Cat : Animal
    {
        public override void PerformTricks()
        {
            Console.WriteLine("Lazy cat {0} is not doing any trick", this.Name);
            // Cat don't want to do any special tricks
            base.PerformTricks();
        }
    }
}
