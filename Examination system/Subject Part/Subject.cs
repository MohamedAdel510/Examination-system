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

        public void CreateSubjectExam()
        {
            int Choice, N, T;
            char ch;
            do
            {
                Console.WriteLine("Please Enter The Type Of Exam(1 for Practical | 2 for Final)");

            } while (!(int.TryParse(Console.ReadLine(), out Choice)) || Choice < 1 || Choice > 2);
            
            do
            {
                Console.WriteLine("Please Enter the Time For Exam From(30 min to 180 min):");
            } while (!int.TryParse(Console.ReadLine(), out T) || T < 30 || T > 180);

            do
            {
                Console.WriteLine("Please Enter Number Of Questions:");
            } while (!int.TryParse(Console.ReadLine(), out N));
            
            switch (Choice)
            {
                case 1:
                    {
                        Exam practicalExam = new PracticalExam();
                        practicalExam.TimeOfExam = T;
                        practicalExam.NumberOfQuestion = N;
                        practicalExam.BuildExam();
                    }
                    break;
                case 2:
                    {
                        Exam finalExam = new FinalExam();
                        finalExam.TimeOfExam = T;
                        finalExam.NumberOfQuestion = N;
                        finalExam.BuildExam();
                    }
                    break;

            }
        }
    }
}