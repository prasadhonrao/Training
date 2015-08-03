using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintUserInfo(null);
            PrintUserInfo(new User());
            PrintUserInfo(new User("Prasad"));

            Console.ReadLine();
        }

        static void PrintUserInfo(User user)
        {
            Console.WriteLine(user?.Name ?? "No Information Provided");
        }
    }

    public class User
    {
        public string Name { get; private set; }

        public User()
        {

        }
        public User(string name)
        {
            this.Name = name;
        }
    }
}
