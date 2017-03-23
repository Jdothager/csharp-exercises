using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz
{
    public class Quiz
    {
        // key contains the question object and the value stores if it has been correctly answered
        public Dictionary<Question, bool> QuestionDict { get; private set; }

        public Quiz(Question question, bool correct = false)
        {
            QuestionDict = new Dictionary<Question, bool> { { question, false } };
        }

        public void AddQuestion(Question question)
        {
            QuestionDict.Add(question, false);
        }
    }
}
