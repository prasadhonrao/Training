using Database_First___Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayCurrencies();

            Console.WriteLine();

            DisplayProductCategories();

            Console.WriteLine();

            WaitConsole();
        }

        private static void DisplayProductCategories()
        {
            Console.WriteLine("\nProduct Categories");
            using (var repo = new ProductCategoryRepository())
            {
                var productCategories = repo.All.ToList();
                foreach (var productCategory in productCategories)
                {
                    Console.WriteLine(productCategory.Name);
                }
            }
        }

        private static void DisplayCurrencies()
        {
            Console.WriteLine("\nCurrencies");
            using (var repo = new CurrencyRepository())
            {
                var currencies = repo.All.ToList();
                foreach (var currency in currencies)
                {
                    Console.WriteLine(currency.Name);
                }
            }
        }

        static void WaitConsole()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
