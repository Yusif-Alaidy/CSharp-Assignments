using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    class TrueOrFalseQuestion:Question
    {
        public TrueOrFalseQuestion(string _header, int _marks, string _correctAnswer)
        {
            Header = _header;
            SetBody();
            Marks = _marks;
            SetCorrectAnswer(_correctAnswer);
        }

        public void SetBody()
        {
            List<string> _body = new();
            _body.Add("true");
            _body.Add("false");
            Body = _body;
                
            
        }
        public override string ToString()
        {
            return $"Header{Header}?({Marks})\n-{Body[0]}\n-{Body[1]}";
        }
    }
}
