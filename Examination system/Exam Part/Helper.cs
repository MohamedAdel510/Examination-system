using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    internal class Helper
    {
        public static MCQ BuildMCQ_Q()
        {
            int QMark, RightAnsID;
            string QBody, QChoice, RightAnsTxt;
            Answers[] answersList;
            Answers rightAnswer;

            Console.Clear();
            // Question Header
            Console.WriteLine("MCQ Question");

            // Entring Question Body
            do
            {
                Console.WriteLine("Please Enter Question Body:");
                QBody = Console.ReadLine()!;
            } while (string.IsNullOrEmpty(QBody) || string.IsNullOrWhiteSpace(QBody));

            // Entring Question Mark
            do
            {
                Console.WriteLine("Please Enter Question Mark: ");
            } while (!int.TryParse(Console.ReadLine(), out QMark));

            Console.WriteLine("Choices of Question");

            // this loop for Entring Choices for Mcq question
            answersList = new Answers[3];
            for (int j = 0; j < answersList.Length; j++)
            {
                //answersList[j].AnswerId = j+1;
                //Answers a = new Answers(); 
                do
                {
                    Console.WriteLine($"Please Enter Choice Number {j + 1}");
                    QChoice = Console.ReadLine()!;
                } while (string.IsNullOrEmpty(QChoice) || string.IsNullOrWhiteSpace(QChoice));
                answersList[j] = new Answers() { AnswerId = j + 1, AnswerText = QChoice };
            }

            // Entring Right Answer
            do
            {
                Console.WriteLine("Please Enter The Right Answer Id");
            } while (!(int.TryParse(Console.ReadLine(), out RightAnsID)) || RightAnsID < 1 || RightAnsID > 3);
            RightAnsTxt = answersList[RightAnsID - 1].AnswerText;
            rightAnswer = new Answers() { AnswerId = RightAnsID, AnswerText = RightAnsTxt };

            return new MCQ()
            {
                Body = QBody,
                Mark = QMark,
                AnswersList = answersList,
                RightAnswer = rightAnswer
            };
        }

        public static TrueOrFalse BuildTF_Q()
        {
            int QMark, RightAnsID;
            string QBody;
            Answers[] answersList;
            Answers rightAnswer;

            Console.Clear();
            // Question Header
            Console.WriteLine("True or False Question");

            //Entering Questoin Body
            do
            {
                Console.WriteLine("Please Enter Question Body:");
                QBody = Console.ReadLine()!;
            } while (string.IsNullOrEmpty(QBody) || string.IsNullOrWhiteSpace(QBody));

            // Entring Question Mark
            do
            {
                Console.WriteLine("Please Enter Question Mark: ");
            } while (!int.TryParse(Console.ReadLine(), out QMark));

            // Entring Right Answer
            do
            {
                Console.WriteLine("Please Enter The Right Answer Id (1 For True | 2 For False)");
            } while (!(int.TryParse(Console.ReadLine(), out RightAnsID)) || RightAnsID < 1 || RightAnsID > 2);

            answersList = new Answers[2] { new Answers() { AnswerId = 1, AnswerText = "True" }, new Answers() { AnswerId = 2, AnswerText = "False" } };
            rightAnswer = new Answers() { AnswerId = answersList[RightAnsID - 1].AnswerId, AnswerText = answersList[RightAnsID - 1].AnswerText };

            return new TrueOrFalse()
            {
                Body = QBody,
                Mark = QMark,
                AnswersList = answersList,
                RightAnswer = rightAnswer
            };
        }
    }
}
