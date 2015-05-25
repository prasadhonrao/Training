using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public struct Foo
    {
        public int value { get; private set; }

        // You need to explicitely call this() from all the other constructor to ensure that all the fields in auto properties are properly initialized

        public Foo(int value) : this()
        {
            this.value = value;
        }
    }
}
