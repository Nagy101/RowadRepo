using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay06
{
    public struct Point2
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2(int _X)
        {
            X = _X;
            Y = 0;
        }
        public Point2(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        override public string ToString()
        {
            return $"X: {X} , Y: {Y}";
        }

    }
}
