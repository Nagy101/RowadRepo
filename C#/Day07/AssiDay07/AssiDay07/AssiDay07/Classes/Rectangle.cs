using AssiDay07.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double _Length,double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
