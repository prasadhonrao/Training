using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value.Type.Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            // int
            var ints = new ValueCollection<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            // DateTime
            var dateTimes = new ValueCollection<DateTime>();
            dateTimes.Add(new DateTime());
            dateTimes.Add(new DateTime().AddDays(10));

            // Guid
            var guids = new ValueCollection<Guid>();
            guids.Add(new Guid());
            guids.Add(new Guid());
            guids.Add(new Guid());

            // Below initialization would fail as Type argument is not a value type

            // var strings = new ValueCollection<string>();
            // var employess = new ValueCollection<Employee>();
            // var intArray = new ValueCollection<int[]>();
            // var objects = new ValueCollection<Object>();
            // var stringBuilders = new ValueCollection<StringBuilder>();
        }
    }

    public class ValueCollection<T> where T : struct
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
