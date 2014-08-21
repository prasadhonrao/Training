using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountNo = 1;
            try
            {
                Employee emp = new Employee();
                Console.WriteLine(emp.GetEmployeeName(accountNo));
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine("Account number {0} is invalid", accountNo);
            }
        }
    }
}
