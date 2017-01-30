using System;
using System.Text;

namespace Mutable_Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Mutable
            var m = new Mutable();
            m.Value = 10;
            m.Value = 20;
            #endregion

            #region 2. ShallowMutable
            StringBuilder builder = new StringBuilder();
            builder.Append("foo");
            var sm = new ShallowMutable(10, builder);
            sm.Builder.Append("bar");
            Console.WriteLine(sm.Builder);
            #endregion

            #region 3. Popsicle
            var p = new Popsicle();
            p.Value = 10;
            p.Freeze();
            //p.Value = 20; //Bang!
            #endregion

            #region 4. ObservableImmutable
        
            #endregion

            Console.ReadLine();
        }
    }
}
