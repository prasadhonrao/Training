using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Mapping___Return_Nothing
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AWEntities())
            {
                context.UpdateProductCategory(3, "Clothing");
            }
        }
    }
}
