using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Using_SP
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContentDbContainer())
            {
                context.Contents.Add(new Content { Text = "Inserted using SP" });
                context.SaveChanges();
            }
        }
    }
}
