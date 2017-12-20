using Mutable_Immutable.Basic;
using Mutable_Immutable.Patterns;
using System;
using System.Text;

namespace Mutable_Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basic

            var r1 = new MutableRectangle();
            r1.Height = 10;
            r1.Length = 5;
            r1.Grow(10, 5);

            Console.WriteLine(r1.ToString());

            #endregion

            #region Patterns

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

            #endregion

            Console.ReadLine();
        }
    }
}
