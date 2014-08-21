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
            var analyst = new Worker();
            
            analyst.WorkPerformed += delegate(int hours, WorkType workType)
                                    {
                                        Console.WriteLine("Work Type : {0}, Hour {1}", workType, hours);
                                    };

            analyst.WorkCompleted += delegate(object sender, EventArgs e) 
                                    {
                                        Console.WriteLine("Work completed.");
                                    };
            
            analyst.DoWork(8, WorkType.Analysis);

            Console.ReadLine();
        }
    }
}
