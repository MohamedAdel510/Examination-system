using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Answers
    {
        public int Id {  get; set; }
        public string Text { get; set; }
        public Answers()
        {
            Text = string.Empty;
        }
        public Answers(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
