using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Answers
    {
        public int AnswerId {  get; set; }
        public string AnswerText { get; set; }

        public Answers()
        {
            AnswerText = string.Empty;
        }
        
        public Answers(int AnswerId, string AnswerText)
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnswerText;
        }
    }
}
