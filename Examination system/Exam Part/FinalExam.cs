using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    internal class FinalExam : Exam
    {
        public MCQ[] MCQ_Questions {  get; set; }
        public TreuOrFalse[] TF_Questions { get; set; }

        public FinalExam()
        {
            MCQ_Questions = new MCQ[NumbersOfQuestion];
            TF_Questions = new TreuOrFalse[NumbersOfQuestion];
        }
        public FinalExam(int TimeOfExam, int NumbersOfQuetions):base(TimeOfExam, NumbersOfQuetions)
        {
            this.MCQ_Questions = new MCQ[NumbersOfQuestion];
            this.TF_Questions = new TreuOrFalse[NumbersOfQuestion];
        }
        public FinalExam(int TimeOfExam, int NumbersOfQuetions, MCQ[] MCQ_Questions, TreuOrFalse[] TF_Questions):base(TimeOfExam, NumbersOfQuetions)
        {
            this.MCQ_Questions = MCQ_Questions;
            this.TF_Questions = TF_Questions;
        }
        public override void ShowExam()
        {
            #region 1
            

           // this.NumbersOfQuestion = N;

            #endregion
           
            Console.Clear();

            #region 2
            for (int i = 0; i < this.NumbersOfQuestion; i++)
            {
                int c;
                do
                {
                    Console.WriteLine("Please Enter Type Of Question: (1 for MCQ | 2 for true or false): ");
                } while (!(int.TryParse(Console.ReadLine(), out c)) || c < 1 || c > 2);

                switch (c)
                {
                    case 1:
                        {
                            int M, R_Ans; string B, Ans;
                            Console.Clear();
                            Console.WriteLine(MCQ_Questions[i].Header);

                            do
                            {
                                Console.WriteLine("Please Enter Question Body:");
                                B = Console.ReadLine()!;
                            } while (string.IsNullOrEmpty(B) || string.IsNullOrWhiteSpace(B));

                            this.MCQ_Questions[i].Body = B;

                            do
                            {
                                Console.WriteLine("Please Enter Question Mark: ");
                            } while (!int.TryParse(Console.ReadLine(), out M));

                            this.MCQ_Questions[i].Mark = M;

                            for (int j = 0; j < this.MCQ_Questions[i].AnswerList.Length; j++)
                            {
                                do
                                {
                                    Console.WriteLine($"Please Enter Choice Number {this.MCQ_Questions[i].AnswerList[j].Id}");
                                    Ans = Console.ReadLine()!;
                                } while (Ans is null);

                                this.MCQ_Questions[i].AnswerList[j].Text = Ans;
                            }

                            do
                            {
                                Console.WriteLine("Please Enter The Right Answer Id: ");
                            } while (!int.TryParse(Console.ReadLine(), out R_Ans));
                            this.MCQ_Questions[i].RightAnswerId = R_Ans;
                        }
                        break;
                    case 2:

                        break;
                }
            }
            #endregion

        }
    }
}
