using AssiDay08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("log message from the ConsoleLogger class.");
        }
    }
}
