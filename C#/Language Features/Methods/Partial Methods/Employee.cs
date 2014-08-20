namespace Training.CSharp
{
    public partial class Employee
    {
        public int Id { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnNameChanged(); }
        }

    }
}
