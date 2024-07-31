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
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam? ExamOfTheSubject { get; set; }
        public Subject()
        {
            Name = string.Empty;
        }
        public Subject(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void CreatExam()
        {
            int Choice;
            do
            {
                Console.WriteLine("Please Enter The Type Of Exam(1 for Practical | 2 for Final)");

            } while (!(int.TryParse(Console.ReadLine(), out Choice)) || Choice < 1 || Choice > 2);

            switch (Choice)
            {
                case 1:
                    //Exam practicalExam = new PracticalExam();


                    break;
                case 2:
                    {
                        int N, T;
                        do
                        {
                            Console.WriteLine("Please Enter the Time For Exam From(30 min to 180 min):"); // validation 
                        } while (!int.TryParse(Console.ReadLine(), out T) || T < 30 || T > 180);

                        do
                        {
                            Console.WriteLine("Please Enter Number Of Questions:");
                        } while (!int.TryParse(Console.ReadLine(), out N));

                        FinalExam finalExam = new FinalExam(T, N);
                        finalExam.ShowExam();
                        break;
                    }

            }
        }
    }
}