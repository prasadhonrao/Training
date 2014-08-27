using DI.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Abstraction
{
    public class TestLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("TEST : Logging message : {0}", message);
        }
    }
}
