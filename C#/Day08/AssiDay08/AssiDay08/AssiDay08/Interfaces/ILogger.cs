using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Interfaces
{
    public interface ILogger
    {
        void log() {
            Console.WriteLine("log message from the ILogger interface.");
        }
    }
}
