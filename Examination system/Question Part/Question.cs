using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question_Part
{
    abstract class Question
    {
        public abstract string Header { get; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[]? AnswersList {  get; set; }
        public Answers? RightAnswer { get; set; }
        

        public Question() { }

        public Question(string? body, int mark, Answers[]? answersList, Answers? rightAnswer)
        {
            Body = body;
            Mark = mark;
            AnswersList = answersList;
            RightAnswer = rightAnswer;
        }
    }
}
