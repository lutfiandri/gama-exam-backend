using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamaExamBackend.Models
{
    public class Question
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int TrueAnswer { get; set; }
    }
}
