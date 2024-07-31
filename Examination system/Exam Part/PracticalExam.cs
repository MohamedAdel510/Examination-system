using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    internal class PracticalExam : Exam
    {
        public MCQ[] MCQ_Questions {  get; set; }

        public PracticalExam()
        {
            MCQ_Questions = new MCQ[NumbersOfQuestion]; 
        }
        public override void ShowExam()
        {
            Console.WriteLine("Show Practical Exam.");
        }
    }
}
