using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritori
{
    public class Question
    {
        public string question {  get; set; }
        public string[] options { get; set; }
        public string correctOption {  get; set; }

        public Question(string question, string[] options, string correctOption)
        {
            this.question = question;
            this.options = options;
            this.correctOption = correctOption;
        }
    }
}
