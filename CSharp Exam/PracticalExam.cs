using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].AddQuestions();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            foreach (var Question in ListOfQuestions)
            {
                // question
                Console.WriteLine(Question);

                // Answers/Choices

                for (int i = 0; i < Question.AnswerList.Length; i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("-----------------------------");

                // User Answer
                int UserAnswerId;

                
                    do
                    {
                        Console.WriteLine("enter number of your answer:");

                    }
                    while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > 3);

                    
                    Console.WriteLine("------------------------------");
               
            }
            Console.Clear();
            Console.WriteLine("right answers:");
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                
                Console.WriteLine($"Right Answer of question{i+1}: {ListOfQuestions[i].RightAnswer.AnswerText}");
            }
        }
    }
}
