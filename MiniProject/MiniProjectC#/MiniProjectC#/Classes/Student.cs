using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectC_.Classes
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void OnExamStarted(object sender, EventArgs e)
        {
            Console.WriteLine($"{Name} notified: Exam Started!");
        }
    }
}
