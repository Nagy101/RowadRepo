using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes
{
    public class Calculator
    {
        public void Sum(int x,int y)
        {
            Console.WriteLine($"Sum of two number = {x+y}");
        }
        public void Sum(int x, int y,int z)
        {
            Console.WriteLine($"Sum of two number = {x + y + z}");
        }
        public void Sum(double x, double y)
        {
            Console.WriteLine($"Sum of two decimal number = {x + y}");
        }
    }
}
