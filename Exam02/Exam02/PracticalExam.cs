using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
public class PracticalExam : Exam
{
    public PracticalExam(DateTime examTime, int numberOfQuestions, Question[] questions)
        : base(examTime, numberOfQuestions, questions) {}

    public override void DisplayExam()
    {
        for (int i = 0; i < Questions.Length; i++)
        {
                Questions[i].DisplayQuestion();
                bool flag = false;
                int x = 0;

                do
                {
                    flag = int.TryParse(Console.ReadLine(), out x);
                } while (!flag || x<= 0);             

            Console.WriteLine("Correct Answer: {0} " , Questions[i].RightAnswer.AnswerText);
        }
    }
}

}
