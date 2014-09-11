using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.With.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = CreateList(typeof(List<Employee>));
            Console.WriteLine("Type {0}", employeeList.GetType().Name);
            Console.WriteLine("Type {0}", employeeList.GetType().FullName);


            // Note List<> is open generic type and CreateGenericList creates a closed generic type
            var newEmployeeList = CreateGenericList(typeof(List<>), typeof(Employee));
            Console.WriteLine("Type {0}", newEmployeeList.GetType().Name);
            Console.WriteLine("Type {0}", newEmployeeList.GetType().FullName);
 
            // Call generic method
            var emp = new Employee();
            var empType = typeof(Employee);
            var methodInfo = empType.GetMethod("Speak");
            methodInfo = methodInfo.MakeGenericMethod(typeof(Employee));
            methodInfo.Invoke(emp, null);

            var methodInfo2 = empType.GetMethod("Speak");
            methodInfo2 = methodInfo2.MakeGenericMethod(typeof(System.DateTime));
            methodInfo2.Invoke(emp, null);
            
            Console.ReadLine();
        }

        private static object CreateGenericList(Type collectionType, Type itemType)
        {
            var closedType = collectionType.MakeGenericType(itemType);
            return Activator.CreateInstance(closedType);
        }

        private static object CreateList(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public void Speak<T>()
        {
            Console.WriteLine("In Generic method");
            Console.WriteLine(typeof(T).FullName);
        }
    }
}
