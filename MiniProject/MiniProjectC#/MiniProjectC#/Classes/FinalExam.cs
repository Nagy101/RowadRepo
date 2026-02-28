using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectC_.Classes
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, Subject subject, QuestionList questions)
            : base(time, subject, questions) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Final Exam ===");

            foreach (var q in Questions)
            {
                q.Display();

                Console.Write("Your Answer (1 or 2): ");
                int userAnswer = int.Parse(Console.ReadLine());

                QuestionAnswers[q] = new Answer(userAnswer.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("=== Exam Review ===");

            foreach (var q in Questions)
            {
                if (q is TrueFalseQuestion tf)
                {
                    int studentAnswer = int.Parse(QuestionAnswers[q].Value);
                    int correctAnswer = tf.CorrectChoice;

                    string result = (studentAnswer == correctAnswer)
                        ? "Correct"
                        : "Wrong";

                    string correctText = correctAnswer == 1 ? "True" : "False";

                    Console.WriteLine($"{q.Body}");
                    Console.WriteLine($"Your Answer: {(studentAnswer == 1 ? "True" : "False")}");
                    Console.WriteLine($"Correct Answer: {correctText}");
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("=== Exam Finished ===");
        }
    }
}
