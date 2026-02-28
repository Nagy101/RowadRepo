using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectC_.Classes
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, Subject subject, QuestionList questions)
            : base(time, subject, questions) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practice Exam ===");

            foreach (var q in Questions)
            {
                q.Display();

                Console.Write("Your Answer (1 or 2): ");
                int userAnswer = int.Parse(Console.ReadLine());

                QuestionAnswers[q] = new Answer(userAnswer.ToString());

                if (q is TrueFalseQuestion tf)
                {
                    if (userAnswer == tf.CorrectChoice)
                        Console.WriteLine("Correct");
                    else
                        Console.WriteLine("Wrong");
                }

                Console.WriteLine();
            }
        }
    }
}
