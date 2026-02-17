using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
        public Student(Student copy)
        {
            Id = copy.Id;
            Name = copy.Name;
            Grade = copy.Grade;
        }

        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
        }
    }
}
