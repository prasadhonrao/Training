namespace Training.CSharp
{
    public class Employee
    {
        public string Name { get; set; }

        public Employee()
        {
            Name = "";
        }

        public Employee(string name)
        {
            this.Name = name;
        }
    }
}
