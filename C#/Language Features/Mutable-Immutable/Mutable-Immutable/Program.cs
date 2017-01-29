using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutable_Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mutable
            var m = new Mutable();
            m.Value = 10;
            m.Value = 20;
            #endregion

            #region ShallowMutable
            StringBuilder builder = new StringBuilder();
            builder.Append("foo");
            var sm = new ShallowMutable(10, builder);
            sm.Builder.Append("bar");
            Console.WriteLine(sm.Builder);
            #endregion

            #region Popsicle
            var p = new Popsicle();
            p.Value = 10;
            p.Freeze();
            p.Value = 20; //Bang
            #endregion
        }
    }
}
