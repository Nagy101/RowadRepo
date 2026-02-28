using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectC_.Classes
{
    public class TrueFalseQuestion : Question
    {
        public int CorrectChoice { get; set; }

        public TrueFalseQuestion(string header, string body, int marks, bool correct)
        : base(header, body, marks)
        {
            CorrectChoice = correct ? 1 : 2;
        }

        public override void Display()
        {
            Console.WriteLine(Body);
            Console.WriteLine("1) True");
            Console.WriteLine("2) False");
        }
    }
}
