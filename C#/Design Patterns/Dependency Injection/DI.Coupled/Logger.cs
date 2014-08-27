using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Coupled
{
    public class Logger
    {
        internal void Log(string message)
        {
            Console.WriteLine("Logging message : {0}", message);
        }
    }
}
