using System;

namespace Auto_Property_Initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine(user.Id);
            Console.ReadLine();
        }
    }

    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}
