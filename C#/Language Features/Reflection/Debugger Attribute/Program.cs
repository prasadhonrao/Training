using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var newAuthor = new Author { Id = 1, Name = "Prasad Honrao" };
            Console.ReadLine();
        }
    }

    [DebuggerDisplay("Inside Author Class. Author Name is {Name}")]
    public class Author
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Id;

        public string Name;
    }
}
