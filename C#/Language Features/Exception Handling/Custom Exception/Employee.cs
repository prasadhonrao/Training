namespace Training.CSharp
{
    public class Employee
    {
        public string GetEmployeeName(int account)
        {
            if (account == 1)
                throw new InvalidAccountException("Invalid account number");
            else
                return "Prasad Honrao";
        }
    }
}
