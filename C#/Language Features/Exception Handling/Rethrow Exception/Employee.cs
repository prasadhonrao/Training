using System;

namespace Training.CSharp
{
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