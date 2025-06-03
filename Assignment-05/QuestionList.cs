using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    /// <summary>
    /// Holds an array of questions and logs each one added.
    /// </summary>
    class QuestionList
    {
        private Question[] questions = new Question[100];
        private int index = 0;
        private string logFile;

        public QuestionList(string fileName)
        {
            logFile = fileName;
        }

        public void Add(Question q)
        {
            if (index < questions.Length)
            {
                questions[index++] = q;

                // Log to file
                File.AppendAllText(logFile, q.ToString() + Environment.NewLine);
            }
        }

        public Question this[int i] => questions[i];

        public int Count => index;
    }
    /// <summary>
    /// Represents a single answer.
    /// </summary>
    class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }

    /// <summary>
    /// Represents a list of answers for a question.
    /// </summary>
    class AnswerList
    {
        public Answer[] Answers = new Answer[10];
        public int Index = 0;

        public void Add(Answer a)
        {
            if (Index < Answers.Length)
                Answers[Index++] = a;
        }
    }
}
