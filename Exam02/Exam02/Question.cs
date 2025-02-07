﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Question
    {
    public string Header {  get; set; }
    
    public string Body { get; set; }    

    public int Mark { get; set; }

    public Answer[] AnswerList {  get; set; }

    public Answer RightAnswer {  get; set; }

        public Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }


        public abstract void DisplayQuestion();
           
        
    }
}
