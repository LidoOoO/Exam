namespace Exam02
{
    internal class Program
    {
        static void Main()
        {

           
            Answer[] answers = {new Answer(1, "2"),new Answer(2, "4"),new Answer(3, "7"),new Answer(4, "5")};

            Question[] questions ={
            new TrueOrFalseQuestion("Question 1", "7 + 8 = 15 ?", 5, new Answer[]{ new Answer(1, "Yes"), new Answer(2, "No") }, new Answer(1, "Yes")),
            new MCQQuestion("Question 2", "X * 4 = 20 X = ?", 10, answers, answers[3])
            };

            Subject mathSub = new Subject(1, "Math");

            Exam finalExam = new FinalExam(DateTime.Now, 2, questions);

            mathSub.CreateExam(finalExam);

            Console.WriteLine("Exam Details :");
            Console.WriteLine(mathSub.SubjectExam.ToString());
            Console.WriteLine("==============\n============");

            mathSub.SubjectExam.DisplayExam();


            

        }
    }
}
