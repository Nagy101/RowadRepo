using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class _Shape : IComparable
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public _Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(object obj)
        {
            _Shape other = (_Shape)obj;
            if (this.Area > other.Area)
                return 1;
            else if (this.Area < other.Area)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"{Name} - Area: {Area}";
        }
    }

}
