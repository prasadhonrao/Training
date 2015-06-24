using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___Enum_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AWEntities())
            {
                var query = context.People.Where(p => p.EmailPromotion == EmailPromotionEnum.Low).Take(5);
                foreach (var person in query)
                {
                    Console.WriteLine("{0} : {1}", person.EmailPromotion, person.FirstName);
                }
            }

            Console.ReadLine();
        }
    }
}
