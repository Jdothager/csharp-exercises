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
            string text;
            if (item is CheckboxQuestion)
            {
                text = "\nChoose all that are correct: \n";
            }
            if (item is MultipleQuestion)
            {
                text = "\nChoose the correct option: \n";
            }
            else
            {
                text = "\nChoose: True or False\n";
            }

            Console.WriteLine(item.QuestionText + text);
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
