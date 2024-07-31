using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public int RightAnswerId {  get; set; }
        public Question()
        {
            Header = string.Empty;
            Body = string.Empty;
        }
        public Question(string header, string body, int mark, int rightAnswerId)
        {
            Header = header;
            Body = body;
            Mark = mark;
            RightAnswerId = rightAnswerId;
        }
    }
}
