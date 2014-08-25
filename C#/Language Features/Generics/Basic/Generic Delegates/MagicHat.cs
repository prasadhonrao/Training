using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public class MagicHat<T> 
    {
        public event EventHandler<ItemManipulatedEventArgs> ItemManipulaed;

        public MagicHat()
        {
            _queue = new Queue<T>();
        }

        private Queue<T> _queue;

        public void Put(T item)
        {
            _queue.Enqueue(item);
            OnItemManipulated(item);
        }

        public T Pull()
        {
            var item = _queue.Dequeue();
            OnItemManipulated(item);
            return item;
        }

        private void OnItemManipulated(T item)
        {
            if (ItemManipulaed != null)
            {
                ItemManipulaed(this, new ItemManipulatedEventArgs { Item = item });
            }
        }

        public string Name
        {
            get;
            set;
        }
    }
}
