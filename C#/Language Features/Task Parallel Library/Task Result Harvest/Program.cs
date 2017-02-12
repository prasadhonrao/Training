using System;
using System.Threading.Tasks;

namespace Task_Result_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> printTask = Task.Factory.StartNew(() => 
            {
                return PrintMessage();
            });

            //  .Result property implicitly calls .Wait
            Console.WriteLine(printTask.Result);

            Console.ReadLine();
        }


        static string PrintMessage()
        {
            Console.WriteLine("Work done!");
            return "Work done message printed";
        }
    }
}
