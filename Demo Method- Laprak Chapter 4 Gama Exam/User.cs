using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Method__Laprak_Chapter_4_Gama_Exam
{
    public abstract class User
    {
        protected string username;

        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public int id;
        //public string fullname;
        public bool isLoggedin = false;

        public User(int ID)
        {
            id = ID;
        }

        public abstract void Login(string username, string password);
    }

    class Creator : User
    {
        public Creator(int ID) : base(ID)
        {
        }

        public override void Login(string username, string password)
        {
            if(username == "creator1" && password == "creator1")
            {
                isLoggedin = true;
            }
            else
            {
                isLoggedin = false;
            }
        }

        public void CreateContest()
        {
        }

        public void EditContest()
        {
        }

        public void DeleteContest()
        {
        }


    }

    class Participant : User
    {
        public Participant(int ID) : base(ID)
        {
        }

        public override void Login(string username, string password)
        {
            if (username == "participant1" && password == "participant1")
            {
                isLoggedin = true;
            }
            else
            {
                isLoggedin = false;
            }
        }

        public void DoAContest()
        {
            QuestionForm question = new QuestionForm();
            question.Show();
        }

        public void SeeResult()
        {
        }
    }
}
