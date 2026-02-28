using MiniProjectC_.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectC_.Classes
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public Subject Subject { get; set; }
        public QuestionList Questions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswers { get; set; }
        public ExamMode Mode { get; set; }

        public event EventHandler ExamStarted;

        protected Exam(int time, Subject subject, QuestionList questions)
        {
            Time = time;
            Subject = subject;
            Questions = questions;
            QuestionAnswers = new Dictionary<Question, Answer>();
            Mode = ExamMode.Queued;
        }
        
        public void StartExam()
        {
            Mode = ExamMode.Starting;
            ExamStarted?.Invoke(this, EventArgs.Empty);
        }

        public abstract void ShowExam();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"{Subject.Name} Exam - Time: {Time}";
        }

        public override bool Equals(object obj)
        {
            Exam e = obj as Exam;
            return e != null && Subject.Name == e.Subject.Name;
        }

        public override int GetHashCode()
        {
            return Subject.Name.GetHashCode();
        }
    }
}
