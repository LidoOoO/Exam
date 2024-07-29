using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{

    public abstract class Exam : ICloneable, IComparable<Exam>
{
    public DateTime ExamTime { get; set; }
    public int NumOfQuestion { get; set; }
    public Question[] Questions { get; set; }

    public Exam(DateTime examTime, int NNumOfQuestion, Question[] questions)
    {
        ExamTime = examTime;
            NumOfQuestion = NNumOfQuestion;
        Questions = questions;
    }

    public abstract void DisplayExam();

    public object Clone()
    {
        return MemberwiseClone();
    }

    public int CompareTo(Exam other)
    {
        if (other == null) return 1;
        return NumOfQuestion.CompareTo(other.NumOfQuestion);
    }

    public override string ToString()
    {
        return $"Exam with {NumOfQuestion} questions at {ExamTime}";
    }
}

}
