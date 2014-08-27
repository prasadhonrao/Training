using System.ComponentModel.Composition;
using DI.MEF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.MEF.Classes
{
    [Export(typeof(ILogger))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging message : {0}", message);
        }
    }
}
