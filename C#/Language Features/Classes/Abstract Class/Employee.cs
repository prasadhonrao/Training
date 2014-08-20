namespace Training.CSharp
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual int CalculateSalary(int noOfDays)
        {
            return noOfDays * 100;
        }
    }
}
