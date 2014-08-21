using System;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var emp = new Employee();
                Console.WriteLine(emp.GetName());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    class Employee
    {
        public string GetName()
        {
            try
            {
                throw new NotImplementedException("Function not implemented");
            }
            catch (NotImplementedException ex)
            {
                throw;  // useful when you just want to log and throw original exception 

                // throw new SystemException("Error", ex);  // useful if you want to hide new exception and encapsulate original - for security reason

                // NOTE - dont use throw ex syntax. It loses all the previous exception stack trace info
            }
        }
    }
}
