using Examination_system.Exam_Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examination_system.Subject_Part
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? ExamOfSubject { get; set; }

        public Subject() { }
        public Subject(int SubjectId, string SubjectName)
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;
        }
        public void CreateSubjectExam()
        {
            ExamOfSubject = SubjectManager.ChosingExamType();
            ExamOfSubject?.BuildExam();
            switch (SubjectManager.CheckForStartExam())
            {
                case 'Y':
                    {
                        Console.Clear();
                        ExamOfSubject?.StartExam();
                    }
                    break;
                case 'N':
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
            Console.Clear();
            ExamOfSubject?.ShowExamResult();

        }


    }
}