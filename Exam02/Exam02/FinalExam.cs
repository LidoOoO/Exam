using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class FinalExam : Exam
    {
        public FinalExam(DateTime examTime, int numberOfQuestions, Question[] questions)
            : base(examTime, numberOfQuestions, questions) { }

        public override void DisplayExam()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].DisplayQuestion();
                {
                    Console.WriteLine($"Mark: {Questions[i].Mark}");
                    Console.WriteLine("Answers:");
                }

                for (int j = 0 ; j < Questions[i].AnswerList.Length;j++)
                {
                    Console.WriteLine($"{j+1}===>  {Questions[i].AnswerList[j].AnswerText}");

                }
                if(i == 0)
                {
                    bool flag = false;
                    int x = 0;

                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out x);
                    } while (!flag  || x > 2 || x < 1);

                    Console.WriteLine("Correct Answer: {0} ", Questions[i].RightAnswer.AnswerText);
                }
                if(i == 1)
                {
                    bool flag = false;
                    int x = 0;

                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out x);
                    } while (!flag  || x > 4 || x < 1);

                    Console.WriteLine("Correct Answer: {0} ", Questions[i].RightAnswer.AnswerText);
                }
                Console.WriteLine(" \n================\n ");
            }
        }
    }

}
