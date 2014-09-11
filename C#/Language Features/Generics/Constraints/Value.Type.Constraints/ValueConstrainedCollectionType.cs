using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value.Type.Constraints
{
    public class ValueConstrainedCollectionType<T> where T : struct
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
    }
}
