using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Method__Laprak_Chapter_4_Gama_Exam
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void lblQuestion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuestionForm question = new QuestionForm();
            question.Show();
        }
    }
}
