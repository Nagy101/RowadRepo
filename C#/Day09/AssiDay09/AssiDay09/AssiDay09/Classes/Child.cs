using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay09.Classes
{
     public class Child : Parent
    {
        public sealed override decimal Salary { get; set; }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }

}
