using DI.CastleWindsor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.CastleWindsor
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging message : {0}", message);
        }
    }
}
