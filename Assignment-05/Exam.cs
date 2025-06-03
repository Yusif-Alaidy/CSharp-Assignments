using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    /// <summary>
    /// Represents the subject of an exam.
    /// </summary>
    class Subject
    {
        public string Name { get; set; }
        public List<Student> Students = new List<Student>();

        public event EventHandler ExamStarted;

        public void StartExam()
        {
            Console.WriteLine($"Exam Started for subject {Name}");
            ExamStarted?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Represents a student.
    /// </summary>
    class Student
    {
        public string Name { get; set; }

        public void OnExamStarted(object sender, EventArgs e)
        {
            Console.WriteLine($"Student {Name} has been notified.");
        }
    }
    /// <summary>
    /// Base Exam class.
    /// </summary>
    abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public Dictionary<Question, AnswerList> QandA { get; set; }
        public string Mode { get; set; } // Starting, Queued, Finished
        public Subject Subject { get; set; }

        public Exam(int time, Subject subject)
        {
            Time = time;
            Subject = subject;
            QandA = new Dictionary<Question, AnswerList>();
            Mode = "Queued";
        }

        public abstract void Show();

        public object Clone() => this.MemberwiseClone();

        public int CompareTo(Exam other) => this.Time.CompareTo(other.Time);

        public override string ToString() => $"Exam: {Time} mins, Subject: {Subject?.Name}, Mode: {Mode}";
        public override bool Equals(object obj) => obj is Exam ex && this.Time == ex.Time;
        public override int GetHashCode() => Time.GetHashCode();
    }
    /// <summary>
    /// Practice exam shows correct answers.
    /// </summary>
    class PracticeExam : Exam
    {
        public PracticeExam(int time, Subject subject) : base(time, subject) { }

        public override void Show()
        {
            foreach (var q in QandA)
            {
                q.Key.Show();
                Console.WriteLine("Correct Answers:");
                foreach (var a in q.Value.Answers)
                    if (a != null && a.IsCorrect)
                        Console.WriteLine($"- {a.Text}");
            }
        }
    }

    /// <summary>
    /// Final exam hides correct answers.
    /// </summary>
    class FinalExam : Exam
    {
        public FinalExam(int time, Subject subject) : base(time, subject) { }

        public override void Show()
        {
            foreach (var q in QandA)
                q.Key.Show();
        }
    }
}
