using System;

namespace Generic.Delegates
{
    public class ItemManipulatedEventArgs :EventArgs
    {
        public object Item { get; set; }
    }
}
