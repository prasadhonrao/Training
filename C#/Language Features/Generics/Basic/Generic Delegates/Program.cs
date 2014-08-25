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
            var magiciansHat = new MagicHat<Animal>();

            magiciansHat.ItemManipulaed += (s, e) => { Console.WriteLine( ((Animal) (e.Item)).Name); };

            magiciansHat.Put(new Animal { Name = "Tuffy" });
            magiciansHat.Put(new Animal { Name = "Muffy" });

            Console.WriteLine(magiciansHat.Pull());

            Console.ReadLine();
        }
    }
}
