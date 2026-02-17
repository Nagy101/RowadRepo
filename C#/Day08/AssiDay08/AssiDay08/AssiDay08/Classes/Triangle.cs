using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height)
            : base(baseLength, height)
        {
        }
        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2; 
        }
        public override double Perimeter
        {
            get
            {
                double hypotenuse = Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
                return Dimension1 + Dimension2 + hypotenuse;
            }
        }
    }
}
