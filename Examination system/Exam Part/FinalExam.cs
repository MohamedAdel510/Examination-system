using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    internal class FinalExam : Exam
    {
        public MCQ[]? MCQ_Questions { get; set; }
        public TrueOrFalse[]? TF_Questions {  get; set; }

        public FinalExam()
        {
            
        }
        
        public override void BuildExam()
        {
            int c; 

            MCQ_Questions = new MCQ[NumberOfQuestion];
            TF_Questions = new TrueOrFalse[NumberOfQuestion];

            for (int i = 0; i < NumberOfQuestion; i++)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Please Enter Type Of Question: (1 for MCQ | 2 for true or false): ");
                } while (!(int.TryParse(Console.ReadLine(), out c)) || c < 1 || c > 2);

                switch (c)
                {
                    case 1:
                        {
                            MCQ_Questions[i] = new MCQ();
                            MCQ_Questions[i] = Helper.BuildMCQ_Q();
                        }
                        break;
                    case 2:
                        {
                            TF_Questions[i] = new TrueOrFalse();
                            TF_Questions[i] = Helper.BuildTF_Q();
                        }
                        break;
                }
            }
        }
        public override void StartExam()
        {
            // Starting the exam
        }
        public override void ShowExamResult()
        {
            //Show Exam Result
        }

    }
}
