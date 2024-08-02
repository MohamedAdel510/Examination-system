using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    internal class PracticalExam : Exam
    {
        public MCQ[]? MCQ_Questions {  get; set; }

        public PracticalExam()
        {
            MCQ_Questions = new MCQ[NumberOfQuestion];
        }
        public override void BuildExam()
        {
            MCQ_Questions = new MCQ[NumberOfQuestion];

            for(int i = 0; i < NumberOfQuestion; i++)
            {
                Console.Clear();
                MCQ_Questions[i] = new MCQ();
                MCQ_Questions[i] = Helper.BuildMCQ_Q();
            }
        }

        public override void ShowExamResult()
        {
            
        }

        public override void StartExam()
        {
            
        }
    }
}
