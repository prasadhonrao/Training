namespace Training.CSharp
{
    public class ContactorEmployee : Employee
    {
        public override int CalculateSalary(int noOfDays)
        {
            return noOfDays * 200;
        }
    }
}
