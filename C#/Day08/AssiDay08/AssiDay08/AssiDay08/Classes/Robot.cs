using AssiDay08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking");
        }
    }
}
