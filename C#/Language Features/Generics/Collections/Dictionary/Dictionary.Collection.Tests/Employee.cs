namespace Dictionary.Collection.Tests
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

        public override string ToString()
        {
            return string.Format("Id : " + this.Id + ", Name : " + this.Name);
        }
    }
}
