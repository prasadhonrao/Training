using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Outer<int>.Inner<string, DateTime>.DummyMethod();
            Outer<string>.Inner<int, int>.DummyMethod();
            Outer<object>.Inner<string, object>.DummyMethod();
            Outer<string>.Inner<string, object>.DummyMethod();
            Outer<object>.Inner<object, string>.DummyMethod();
            Outer<string>.Inner<int, int>.DummyMethod();

            Console.ReadLine();
        }
    }

    public class Outer<T>
    {
        public class Inner<U, V>
        {
            static Inner()
            {
                Console.WriteLine("Outer <{0}>.Inner<{1}, {2}>",
                                   typeof(T).Name,
                                   typeof(U).Name,
                                   typeof(V).Name);
            }
            public static void DummyMethod() { }
        }
    }
}
