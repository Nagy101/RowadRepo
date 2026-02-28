using MiniProjectC_.Classes;
using System;

namespace MiniProjectC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject("OOP");

            QuestionList qList = new QuestionList("questions.txt");
            qList.Add(new TrueFalseQuestion("Q1", "C# is OOP?", 5, true));

            Exam practice = new PracticeExam(60, sub, qList);
            Exam finalExam = new FinalExam(60, sub, qList);

            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1) Practice");
            Console.WriteLine("2) Final");

            int choice = int.Parse(Console.ReadLine());

            Exam selectedExam = (choice == 1) ? practice : finalExam;
            selectedExam.ShowExam();
        }
    }
}
