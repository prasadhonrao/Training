using System;

namespace Generic.Type.With.Static.Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeWithField<int>.field = "First";
            TypeWithField<string>.field = "Second";
            TypeWithField<DateTime>.field = "Third";
            
            TypeWithField<int>.PrintField();
            TypeWithField<string>.PrintField();
            TypeWithField<DateTime>.PrintField();

            Console.WriteLine("*******************************");

            Outer<int>.Inner<string, DateTime>.DummyMethod();
            Outer<string>.Inner<int, int>.DummyMethod();
            Outer<object>.Inner<string, object>.DummyMethod();
            Outer<string>.Inner<string, object>.DummyMethod();
            Outer<object>.Inner<object, string>.DummyMethod();
            Outer<string>.Inner<int, int>.DummyMethod(); //wont print as Inner static constructor was already called for <int,int> signature. Static constructor gets called only once.

            Console.ReadLine();
        }
    }

    class TypeWithField<T>
    {
        public static string field;
        public static void PrintField()
        {
            Console.WriteLine(field + ": " + typeof(T).Name);
        }
    }


    public class Outer<T>
    {
        public class Inner<U, V>
        {
            static Inner()
            {
                Console.WriteLine("Outer<{0}>.Inner<{1},{2}>",
                typeof(T).Name,
                typeof(U).Name,
                typeof(V).Name);
            }
            public static void DummyMethod() { }
        }
    }
}
