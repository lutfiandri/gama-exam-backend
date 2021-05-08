using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Method__Laprak_Chapter_4_Gama_Exam
{
    class Contest
    {
        public int id;
        public Contest(int ID)
        {
            id = ID;
        }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public object QuestionList = new List<QuestionForm>() ;
    }
    
    class Question
    {
        public int id;
        private int contest_id;
        public string questionText;
        public string[] answers = new string[5];
        public char trueanswer;
    }

}
