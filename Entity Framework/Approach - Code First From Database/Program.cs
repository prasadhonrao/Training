using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Approach___Code_First_From_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWModel())
            {
                context.vSalesPersons.ToList().ForEach(c => Console.WriteLine(c.FirstName + " " + c.LastName + " , " + c.EmailAddress ));
                Console.WriteLine("Press [Enter] to exit...");
                Console.ReadLine();
            }
        }
    }
}
