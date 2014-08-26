using System.Collections;

namespace Training.CSharp
{
    class ProductComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Product)x).Name.CompareTo(((Product)y).Name);
        }
    }
}
