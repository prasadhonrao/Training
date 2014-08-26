using System.Collections.Generic;

namespace Training.CSharp
{
    public class SupplierRepository
    {
        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier { Id = 1, Name = "Microsoft"},
                new Supplier { Id = 2, Name = "Apple"},
                new Supplier { Id = 3, Name = "Samsung"},
                new Supplier { Id = 4, Name = "Google"},
                new Supplier { Id = 5, Name = "All In One Sales"},
                new Supplier { Id = 6, Name = "New Supplier"}
            };
        }
    }
}
