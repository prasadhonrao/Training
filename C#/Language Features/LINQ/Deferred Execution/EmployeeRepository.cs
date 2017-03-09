using System.Collections.Generic;

namespace Training.CSharp
{
    public class EmployeeRepository
    {
        List<Employee> _employee;

        public List<Employee> GetEmployees()
        {
            _employee = new List<Employee> 
            {
                new Employee { Id = 1, Name = "Prasad"},
                new Employee { Id = 2, Name = "Amit"},
                new Employee { Id = 3, Name = "Rahul"},
                new Employee { Id = 4, Name = "John"},
                new Employee { Id = 5, Name = "Rita"},
                new Employee { Id = 6, Name = "Paul"}
            };

            return _employee;
        }

        public void AddEmployee(Employee e)
        {
            _employee.Add(e);
        }
    }
}
