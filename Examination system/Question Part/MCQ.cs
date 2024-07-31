using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class MCQ:Question
    {
        public Answers[] AnswerList {  get; set; }

        public MCQ()
        {
            Header = "MCQ Quetion";
            AnswerList = new Answers[3];
            AnswerList[0].Id = 1;
            AnswerList[1].Id = 2;
            AnswerList[2].Id = 3;
        }
        public MCQ(string header, string body, int mark, int rightAnswerId, Answers[] answerList):base(header, body, mark, rightAnswerId)
        {
            this.AnswerList = answerList;
        }
    }
}
