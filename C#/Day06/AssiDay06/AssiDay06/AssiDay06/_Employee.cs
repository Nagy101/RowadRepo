using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay06
{
    public class _Employee
    {
        private int EmpId;
        private string EmpName;
        private double EmpSalary;
        public string Name
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

    }
}
