using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    public class MCQQuestion : Question
    {
        public override string Header => "MCQ Question";

        public MCQQuestion()        
        {
            AnswerList = new Answer[3]; 
        }
        public override void AddQuestions()
        {
            // Header
            Console.WriteLine(Header);

            // Body
            Console.WriteLine("Enter body of Question");
            Body = Console.ReadLine();

            // Marks
            int mark;
            do
            {
                Console.WriteLine("enter marks of question");

            }while(!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

            Marks = mark;           

            // Answers of question

            Console.WriteLine("enter answers of question:");
            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId= i+1
                };
                            
                Console.WriteLine($"Enter answer number{i+1}:");
                AnswerList[i].AnswerText = Console.ReadLine();
            }


            // Right Answer

            int rightAnswerId;
            do
            {
                Console.WriteLine("enter id of the right answer:");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 3);

            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId-1].AnswerText;

            Console.Clear();
        }
    }
}
