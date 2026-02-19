using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay09.Struct
{
    public struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
    }

}
