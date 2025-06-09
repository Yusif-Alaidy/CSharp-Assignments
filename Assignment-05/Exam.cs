using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    class Exam
    {
        public List<ChooseOneQuestion> chooseOneQuestions = new();
        public List<TrueOrFalseQuestion> trueOrFalseQuestions = new();

        public void AddQuestion(ChooseOneQuestion chooseOneQuestion)
        {
            this.chooseOneQuestions.Add(chooseOneQuestion);
        }
        public void AddQuestion(TrueOrFalseQuestion  trueOrFalseQuestion)
        {
            this.trueOrFalseQuestions.Add(trueOrFalseQuestion);
        }
    }
}
