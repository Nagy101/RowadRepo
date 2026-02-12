using AssiDay07.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double _Radius)
        {
            Radius = _Radius;
        }
        public double Area {
            get { return 3.14 * Radius * Radius; }
        }
        public void Draw()
         =>   Console.WriteLine("Drawing a Circle");
    }
}
