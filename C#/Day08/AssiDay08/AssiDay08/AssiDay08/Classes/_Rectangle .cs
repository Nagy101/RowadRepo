using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class _Rectangle : GeometricShape
    {
        public _Rectangle(double length, double width)
            : base(length, width)
        {
        }
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }
        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }
    }

}
