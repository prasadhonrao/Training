using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.Print(10, 20);
            p.Print(x: 55, y: 66);
            p.Print(y: 55, x: 36);
            p.Print(30);
            p.Print(x: 30); // parameter name is important here

            Console.Read();
        }
    }

    public class Parent
    {
        public void Print(int x = 10, int y = 20)
        {
            Console.WriteLine("Print with 2 params X : {0} , Y : {1}", x, y);
        }

        public void Print(int y = 10)
        {
            Console.WriteLine("Print with 1 param Y : {0} ", y);
        }

        public void Print<T>(T x)
        {
            Console.WriteLine("Generic Print X : {0} ", x);
        }
    }
}
