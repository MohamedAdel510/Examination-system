using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion {  get; set; }
        public Answers[]? StudenAnswers { get; set; }

        private protected int grade;

        public int Grade
        {
            set { grade = value; }
            get { return grade; }
        }
        public Exam()
        {
            StudenAnswers = new Answers[NumberOfQuestion];
            Grade = 0;
        }

        public abstract void BuildExam();
        public abstract void StartExam();
        public abstract void ShowExamResult();
    }
}
