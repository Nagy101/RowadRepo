using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay10.Classes
{
    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public object Clone()
        {
            return new Employee(Name, Salary);
        }
    }
}
