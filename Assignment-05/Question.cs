using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    /// <summary>
    /// Base abstract class for any question.
    /// </summary>
    abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

        public abstract void Show();

        public override string ToString() => $"{Header} - {Body} ({Marks} marks)";
    }

    /// <summary>
    /// True/False question.
    /// </summary>
    class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks)
            : base(header, body, marks) { }

        public override void Show()
        {
            Console.WriteLine($"{Header}\n{Body}\nA) True\nB) False");
        }
    }

    /// <summary>
    /// Single correct answer.
    /// </summary>
    class ChooseOneQuestion : Question
    {
        public string[] Options { get; set; }

        public ChooseOneQuestion(string header, string body, int marks, string[] options)
            : base(header, body, marks)
        {
            Options = options;
        }

        public override void Show()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < Options.Length; i++)
                Console.WriteLine($"{(char)('A' + i)}) {Options[i]}");
        }
    }

    /// <summary>
    /// Multiple correct answers.
    /// </summary>
    class ChooseAllQuestion : Question
    {
        public string[] Options { get; set; }

        public ChooseAllQuestion(string header, string body, int marks, string[] options)
            : base(header, body, marks)
        {
            Options = options;
        }

        public override void Show()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < Options.Length; i++)
                Console.WriteLine($"{(char)('A' + i)}) {Options[i]}");
        }
    }

}
