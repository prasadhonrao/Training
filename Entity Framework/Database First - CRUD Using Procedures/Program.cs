using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___CRUD_Using_Procedures
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContentEntities())
            {
                context.Contents.Add(new Content { Text = "Inserted using SP" });
                context.SaveChanges();
            }
        }
    }
}
