using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz
{
    public abstract class Question
    {
        public string QuestionText { get;  set; }
        public List<string> Solution { get; set; }
        public List<string> Options { get; set; }
        public List<string> SubmittedAnswer { get; set; }
    }
}
