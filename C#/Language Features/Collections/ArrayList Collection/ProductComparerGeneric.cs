using System.Collections.Generic;

namespace Training.CSharp
{
    class ProductComparerGeneric : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
