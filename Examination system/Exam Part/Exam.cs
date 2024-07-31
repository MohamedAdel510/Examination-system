using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    abstract class Exam
    {
        public int TimeOfExam {  get; set; }
        public int NumbersOfQuestion {  get; set; }

        public Exam() { }

        public Exam(int TimeOfExam, int NumbersOfQuestion)
        {
            this.TimeOfExam = TimeOfExam;
            this.NumbersOfQuestion = NumbersOfQuestion;
        }

        public abstract void ShowExam();
    }
}
