using Examination_system.Question_Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class TrueOrFalse : Question
    {
        public override string Header => "True or False Question";

        public TrueOrFalse()
        {
            
        }
        public TrueOrFalse(string? body, int mark, Answers[]? answersList, Answers? rightAnswer):base(body, mark, answersList, rightAnswer)
        {

        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\n {Mark}\n{AnswersList[0]?.AnswerId}\n{AnswersList[0].AnswerText}\n{AnswersList[1]?.AnswerId}\n{AnswersList[1].AnswerText}\n{RightAnswer}";
        }
    }
}
