using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay09.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //public override string ToString()
        //{
        //    return $"Employee(Id: {Id}, Name: {Name})";
        //}
        public override string ToString()
        {
            return $"Employee(Id: {Id}, Name: {Name}, Department: {Department.Name})";
        }
    }

}
