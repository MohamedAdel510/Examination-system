using Examination_system.Question_Part;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam_Part
{
    static class ExamManager
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

        public static void StartQuestions(Question[]? Questions, Answers[]? StudenAnswers, ref int Grade)
        {
            int AnsId;
            if (Questions is not null)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    if (Questions[i] is not null)
                    {
                        Console.WriteLine($"{Questions[i]?.Header}\tMark {Questions[i]?.Mark}");
                        Console.WriteLine();
                        Console.WriteLine(Questions[i]?.Body);

                        for (int j = 0; j < Questions[i]?.AnswersList?.Length; j++)
                        {
                            Console.WriteLine($"{Questions[i]?.AnswersList[j]?.AnswerId}-{Questions[i]?.AnswersList[j]?.AnswerText}");
                        }

                        Console.WriteLine();

                        do
                        {
                            Console.WriteLine("Please Enter The Answer Id");
                        } while (!(int.TryParse(Console.ReadLine(), out AnsId)) || AnsId < 1 || AnsId > 3);

                        StudenAnswers[i] = new Answers() { AnswerId = AnsId, AnswerText = Questions[i]?.AnswersList[AnsId - 1]?.AnswerText };

                        if (StudenAnswers[i].AnswerId == Questions[i]?.RightAnswer?.AnswerId)
                        {
                            Grade += Questions[i].Mark;
                        }
                    }
                    continue;   
                }
            }
        }
        
        public static int ShowQuestionsResult(Question[]? Questions, Answers[]? StudenAnswers)
        {
            int TotalMark = 0;
            if(Questions is not null)
            {
                for(int i = 0; i < Questions.Length; i++)
                {
                    if (Questions[i] is not null)
                    {
                        Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
                        Console.WriteLine($"Your Answer => {StudenAnswers[i]?.AnswerText}");
                        Console.WriteLine($"Right Answer => {Questions[i].RightAnswer?.AnswerText}");
                        TotalMark += Questions[i].Mark;
                    }
                    continue;
                }
            }
            return TotalMark;
        }
    }
}
