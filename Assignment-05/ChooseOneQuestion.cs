using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string _header, List<string> _body, int _marks, string _correctAnswer)
        {
            Header = _header;
            SetBody(_body);
            Marks = _marks;
            SetCorrectAnswer(_correctAnswer);
        }
        public bool SetBody(List<string> _body)
        {
            if (_body.Count() == 4)
            {
                Body = _body;
                return true;
            }
            else
            {
                throw new InvalidOperationException("Invalid Data Please Give Enter Two Answer: ");

            }
        }
        public override string ToString()
        {
            return $"Header{Header}?({Marks})\n-{Body[0]}\n-{Body[1]}\n-{Body[2]}\n-{Body[3]}";
        }
    }
}
