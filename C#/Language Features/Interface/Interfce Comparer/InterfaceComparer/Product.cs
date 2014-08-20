using System.Collections;
using System.Collections.Generic;

namespace Training.CSharp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static ArrayList GetSampleProductsInArrayList()
        {
            var list = new ArrayList();
            list.Add(new Product { Id = 1, Name = "Surface", Price = 999.99m });
            list.Add(new Product { Id = 2, Name = "iPad", Price = 699.99m });
            list.Add(new Product { Id = 3, Name = "iPod", Price = 199.39m });
            list.Add(new Product { Id = 4, Name = "Sumsung Tablet", Price = 555.99m });
            list.Add(new Product { Id = 5, Name = "Digital Camera", Price = 1234.99m });
            list.Add(new Product { Id = 6, Name = "Kindle Reader", Price = 89.99m });
            return list;
        }

        public static List<Product> GetSampleProductsInList()
        {
            return new List<Product> 
            {
                new Product { Id = 1, Name = "Surface",Price = 999.99m  },
                new Product { Id = 2, Name = "iPad" ,Price = 699.99m},
                new Product { Id = 3, Name = "iPod" , Price = 199.39m},
                new Product { Id = 4, Name = "Sumsung Tablet" , Price = 555.99m},
                new Product { Id = 5, Name = "Digital Camera", Price = 1234.99m  },
                new Product { Id = 6, Name = "Kindle Reader" , Price = 89.99m}
            };
        }

        public override string ToString()
        {
            return this.Id + " " + this.Name + " " + this.Price;
        }
    }

    public class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;

            return first.Name.CompareTo(second.Name);
        }
    }

    public class ProductPriceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;

            return first.Price.CompareTo(second.Price);
        }
    }

    public class ProductNameGenericComparer : IComparer<Product>
    {
        public int Compare(Product first, Product second)
        {
            return first.Name.CompareTo(second.Name);
        }
    }
}
