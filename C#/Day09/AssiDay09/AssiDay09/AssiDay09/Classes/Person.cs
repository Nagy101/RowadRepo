using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay09.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public  string Department { get; set; }
        override public string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Department: {Department}";
        }
    }

}
