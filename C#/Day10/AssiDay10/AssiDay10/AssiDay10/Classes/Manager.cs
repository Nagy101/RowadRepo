using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay10.Classes
{
    public class Manager : Employee, IComparable<Manager>
    {
        public Manager(string name, double salary): base(name, salary)
        {

        }

        public int CompareTo(Manager other)
        {
            if (other == null) return 1;

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
