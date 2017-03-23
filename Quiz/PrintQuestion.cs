using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz
{
    public class PrintQuestion
    {
        public static void PrintTheQuestion(Question item)
        {
            Console.WriteLine(item.QuestionText + "\nChoose all that are correct: \n");
            foreach (string option in item.Options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("\n");

            string userInput;
            do
            {
                userInput = Console.ReadLine();
                item.SubmittedAnswer.Add(userInput);
            } while (userInput.Trim() != "");
        }
    }
}
