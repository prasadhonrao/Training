using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            new ObsoleteClass();

            new ClasswithObsoleteMember { Name = "C#" };

            // new ObsoleteClassWithErrorMessage();
        }
    }

    [Obsolete]
    class ObsoleteClass { }

    class ClasswithObsoleteMember
    {
        [Obsolete("Name is obsolete")]
        public string Name { get; set; }
    }

    [Obsolete("You are using obsolete class", true)]
    class ObsoleteClassWithErrorMessage { }
}
