using System;
namespace Training.CSharp
{
    public partial class Employee
    {
        // This is just for partial methods example purpose
        // Property value change detection is better handled using INotifyPropertyChanged interface
        void OnNameChanged()
        {
            Console.WriteLine("Name changed");
        }
    }
}
