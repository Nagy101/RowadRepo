using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
        public override void Display()
        {
            Console.WriteLine($"Circle with radius: {Radius}, Area: {GetArea()}");
        }

    }
}
