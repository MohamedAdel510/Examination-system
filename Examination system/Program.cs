using Examination_system.Exam_Part;
using Examination_system.Subject_Part;
using System.Timers;
using System;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject();
            s.CreateSubjectExam();
        }
    }
}
