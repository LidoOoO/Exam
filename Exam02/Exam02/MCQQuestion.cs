using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
      : base(header, body, mark, answerList, rightAnswer) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
            }
        }
    }
}
