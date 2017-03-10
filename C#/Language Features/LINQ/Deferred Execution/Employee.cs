namespace Training.CSharp
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
