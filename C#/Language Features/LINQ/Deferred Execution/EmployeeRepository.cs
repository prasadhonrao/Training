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
                new Employee (1,"Prasad"),
                new Employee (2,"Amit"),
                new Employee (3,"Rahul"),
                new Employee (4,"John"),
                new Employee (5,"Rita"),
                new Employee (6,"Paul")
            };

            return _employee;
        }

        public void AddEmployee(Employee e)
        {
            _employee.Add(e);
        }
    }
}
