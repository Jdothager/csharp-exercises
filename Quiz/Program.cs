using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CheckboxQuestion q1 = new CheckboxQuestion("Is this working?", new List<string> { "yes" }, new List<string> { "yes", "no" }, new List<string>());
            MultipleQuestion q2 = new MultipleQuestion("Is this still working?", new List<string> { "yes" }, new List<string> { "yes", "no" }, new List<string>());

            Quiz quiz1 = new Quiz(q1);
            quiz1.AddQuestion(q2);

            foreach (KeyValuePair<Question, bool> question in quiz1.QuestionDict)
            {
                PrintQuestion.PrintTheQuestion(question.Key);
            }

            Console.WriteLine("well, I guess that worked");
            Console.ReadLine();
        }
    }
}
