using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    abstract class Question
    {
        public string Header { get; set; }
        public List<string> Body { get; set; }
        public int Marks { get; set; }
        public string CorrectAnswer { get; protected set; }
        public bool SetCorrectAnswer(string _correctAnswer)
        {
            if (Body.Contains(_correctAnswer))
            {
                CorrectAnswer = _correctAnswer;
                return true;
            }
            else
            {
                throw new InvalidDataException("This Answer is not in the answers! ");
            }
        }
        public bool IsCorrect(string answer) => answer == CorrectAnswer;



    }
}
