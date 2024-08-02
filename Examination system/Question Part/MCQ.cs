using Examination_system.Question_Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class MCQ : Question
    {
        public override string Header => "MCQ Question";

        public MCQ()
        {
           
        }

        public MCQ(string? body, int mark, Answers[]? answersList, Answers? rightAnswer):base(body, mark, answersList, rightAnswer) 
        {

        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\n {Mark}\n{AnswersList[0]?.AnswerId}\n{AnswersList[1]?.AnswerId}\n{AnswersList[2]?.AnswerId}\n{RightAnswer}";
        }
    }
}
