using System;

namespace Generic.Type.Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new MyType();
            var t2 = new MyType<string>();
            var t3 = new MyType<string, string>();
            Console.ReadLine();
        }
    }

    public class MyType
    {
        public MyType()
        {
            Console.WriteLine("In MyType constructor");
        }
    }

    public class MyType<T>
    {
        public MyType()
        {
            Console.WriteLine("In MyType<T> constructor");
        }
    }

    public class MyType<T, U>
    {
        public MyType()
        {
            Console.WriteLine("In MyType<T, U> constructor");
        }
    }
    
}
