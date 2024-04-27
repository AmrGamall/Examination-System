using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    public class TFQuestion : Question
    {
        public override string Header => "True/False Question";

        public TFQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");
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

            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

            Marks = mark;

            // Right Answer

            int rightAnswerId;
            do
            {
                Console.WriteLine("enter id of the right answer:");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 2);

            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId - 1].AnswerText;

            Console.Clear();
        }
    }
}
