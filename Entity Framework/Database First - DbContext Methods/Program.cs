using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___DbContext_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNewProductCategory();
            UpdateProductCategory();
            DeleteProductCategory();

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();

        }

        private static void AddNewProductCategory()
        {
            using (var context = new AWEntities())
            {
                var newCategory = new ProductCategory
                {
                    Name = "New Product Category"
                };
                context.ProductCategories.Add(newCategory);

                Console.WriteLine(context.Entry(newCategory).State);
            }
        }
        
        private static void UpdateProductCategory()
        {
            using (var context = new AWEntities())
            {
                var existingCategory = context.ProductCategories.Find(1);
                existingCategory.Name = "Updated Category";
                Console.WriteLine(context.Entry(existingCategory).State);
            }
        }
        
        private static void DeleteProductCategory()
        {
            using (var context = new AWEntities())
            {
                var categoryToDelete = context.ProductCategories.Find(1);
                if (categoryToDelete != null)
                {
                    context.ProductCategories.Remove(categoryToDelete);
                    Console.WriteLine(context.Entry(categoryToDelete).State);
                }
            }
        }
    }
}
