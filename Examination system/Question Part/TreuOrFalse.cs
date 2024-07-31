using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class TreuOrFalse:Question
    {
        TreuOrFalse()
        {
            Header = "True or False Question";
        }

        TreuOrFalse(string header, string body, int mark, int rightAnswerId):base(header, body, mark, rightAnswerId) 
        {
            
        }
    }
}
