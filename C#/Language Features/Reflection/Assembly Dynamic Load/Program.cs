using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load type dynamically
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface("ILogger") != null)
                {
                    var instance = Activator.CreateInstance(type) as ILogger;
                    if (instance != null)
                    {
                        instance.Log("Dynamic logging");
                        break;
                    }
                }
            }

            // Load assembly dynamically
            Assembly exe = Assembly.LoadFrom(@"../../TypeInformation.exe");
            foreach (Type item in exe.GetTypes())
            {
                if (item.Name.Equals("Employee"))
                {
                    dynamic empInstance = Activator.CreateInstance(item);
                    string name = empInstance.GetInfo(1);
                    Console.WriteLine("Employee Name {0}", name);
                    break;
                }
            }

            Console.ReadLine();
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
