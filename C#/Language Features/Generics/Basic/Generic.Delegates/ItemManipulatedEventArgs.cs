using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic.Delegates
{
    public class ItemManipulatedEventArgs :EventArgs
    {
        public object Item { get; set; }
    }
}
