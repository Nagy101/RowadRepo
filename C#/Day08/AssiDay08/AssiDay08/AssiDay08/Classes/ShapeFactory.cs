using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class ShapeFactory
    {
        public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "triangle":
                    return new Triangle(dim1, dim2);
                case "rectangle":
                    return new _Rectangle(dim1, dim2);
                default:
                    Console.WriteLine("Invalid shape type");
                    return null;
            }
        }
    }
}
