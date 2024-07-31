using Examination_system.Exam_Part;
using Examination_system.Subject_Part;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s1 = new Subject(1, "C#");
            s1.CreatExam(); 
        }
    }
}
