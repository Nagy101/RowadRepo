using AssiDay08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike start");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike stop");
        }
    }
}
