using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectC_.Classes
{
    public class ChooseAllQuestion : Question
    {
        public string[] Choices { get; set; }
        public int[] CorrectIndexes { get; set; }

        public ChooseAllQuestion(string header, string body, int marks,
                                 string[] choices, int[] correctIndexes)
            : base(header, body, marks)
        {
            Choices = choices;
            CorrectIndexes = correctIndexes;
        }

        public override void Display()
        {
            Console.WriteLine(Body);
            for (int i = 0; i < Choices.Length; i++)
                Console.WriteLine($"{i + 1}) {Choices[i]}");
        }
    }
}
