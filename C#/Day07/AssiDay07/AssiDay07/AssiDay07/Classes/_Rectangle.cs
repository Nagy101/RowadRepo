using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes
{
    public class _Rectangle : Shape
    {
        public double Length { get; set; } 
        public double Width { get; set; } 
        public _Rectangle(double _Length, double _Width)
        { 
            Length = _Length;
            Width = _Width; 
        }
        public override void Draw()
        {
            Console.WriteLine("Shape is Rectangle");
        }
        public override void CalculateArea()
        {
            Console.WriteLine($"Area = {Length*Width}");
        }
    }
}
