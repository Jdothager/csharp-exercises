using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz
{
    public class CheckboxQuestion : Question
    {

        public CheckboxQuestion(string questionText, List<string> solution, List<string> options, List<string> submittedAnswer)
        {
            this.QuestionText = questionText;
            this.Solution = solution;
            this.Options = options;
            this.SubmittedAnswer = submittedAnswer;
        }
    }
}
