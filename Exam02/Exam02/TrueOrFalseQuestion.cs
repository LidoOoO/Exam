using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer) : base(header, body, mark, answerList, rightAnswer) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine("{0}\n{1}\n1.Yes \n2.No" , Header , Body);
        }
    }
}
