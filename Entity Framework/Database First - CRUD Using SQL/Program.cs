using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___CRUD_Using_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // InsertNewProductCategory();
            // UpdateProductCategory();
            // DeleteProductCategory();

            Console.WriteLine("Press [Enter] to quit...");
            Console.ReadLine();
        }

        private static void DeleteProductCategory()
        {
            using (var context = new AWEntities())
            {
                var category = context.ProductCategories.Where(c => c.Name == "Updated Category").FirstOrDefault();
                context.ProductCategories.Remove(category);
                context.SaveChanges();
            }
        }

        private static void UpdateProductCategory()
        {
            using (var context = new AWEntities())
            {
                var category = context.ProductCategories.Where(c => c.Name == "New Category").FirstOrDefault();
                category.Name = "Updated Category";
                context.SaveChanges();
            }
        }

        private static void InsertNewProductCategory()
        {
            using (var context = new AWEntities())
            {
                var newProductCategory = new ProductCategory
                {
                    Name = "New Category",
                    rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now
                };

                context.ProductCategories.Add(newProductCategory);
                context.SaveChanges();
            }
        }
    }
}
