using System.Collections;
using System.Collections.Generic;

namespace Training.CSharp
{
    public class EmployeeRepository
    {
        public Employee[] GetUsingConcreteClass()
        {
            return new Employee[] 
                { 
                    new Employee() { Firstname = "Prasad", Lastname = "Honrao", Department = "Admin" },
                    new Employee() { Firstname = "Colin", Lastname = "Gray", Department = "Support" } 
                };
        }

        //public List<Employee> GetUsingConcreteClass()
        //{
        //    return new List<Employee>
        //        { 
        //            new Employee() { Firstname = "Prasad", Lastname = "Honrao", Department = "Admin" },
        //            new Employee() { Firstname = "Colin", Lastname = "Gray", Department = "Support" } 
        //        };
        //}

        public IEnumerable GetUsingInterface()
        {
            return new List<Employee>
                { 
                    new Employee() { Firstname = "Prasad", Lastname = "Honrao", Department = "Admin" },
                    new Employee() { Firstname = "Colin", Lastname = "Gray", Department = "Support" }, 
                    new Employee() { Firstname = "John", Lastname = "Papa", Department = "Training" } 
                };
        }
    }
}
