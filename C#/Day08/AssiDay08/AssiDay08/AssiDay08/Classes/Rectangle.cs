using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double GetArea()
        {
            return Length * Width;
        }
        public override void Display()
        {
            Console.WriteLine($"Rectangle with length: {Length}, width: {Width}, Area: {GetArea()}");
        }
    }
}
