using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Type.Constraints
{
    public class ReferenceConstrainedCollection<T> where T : class
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
    }
}
