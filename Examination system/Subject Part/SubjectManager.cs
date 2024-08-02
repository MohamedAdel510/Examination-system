using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_system.Exam_Part;

namespace Examination_system.Subject_Part
{
    static class SubjectManager
    {
        public static Exam ChosingExamType()
        {
            int Choice, N, T;

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
            } while ((!int.TryParse(Console.ReadLine(), out N)) || N < 1);

            if(Choice == 1)
            {
                return new PracticalExam()
                {
                    TimeOfExam = T,
                    NumberOfQuestion = N,
                };
            }
            else
            {
                return new FinalExam()
                {
                    TimeOfExam = T,
                    NumberOfQuestion = N,
                };
            }
            
        }

        public static char CheckForStartExam()
        {
            char ch;
            Console.Clear();
            bool validCh, flag;
            do
            {
                Console.WriteLine("Do You Want To Start The Exam ( Y | N )");
                flag = char.TryParse(Console.ReadLine(), out ch);
                if (ch == 'Y' || ch == 'y' || ch == 'N' || ch == 'n')
                    validCh = true;
                else 
                    validCh = false;

            } while (!flag || !validCh); ;

            if (char.IsLower(ch))
                ch = char.ToUpper(ch);

            return ch;
        }
    }
}
