using System;
namespace CSharp.Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer { Id = 1, Name = "Prasad Honrao" };
            Order order = new Order() { Id = 1, OrderDate = DateTime.Now };

            var dometstic = new DomesticOrderProcessor(cust, order);
            dometstic.Process();

            var international = new InternationalOrderProcessor(cust, order);
            international.Process();

            Console.ReadLine();
        }
    }
}
