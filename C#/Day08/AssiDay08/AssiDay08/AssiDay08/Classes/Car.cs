using AssiDay08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Car : IVehicle
    {

        public void StartEngine()
        {
            Console.WriteLine("Car start");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car stop");

        }
    }
}
