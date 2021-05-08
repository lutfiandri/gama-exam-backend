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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant(1);
            participant.Login(tb_Username.Text, tb_Password.Text);
            if (participant.isLoggedin)
            {
                participant.DoAContest();
            }
            else
            {
                MessageBox.Show("username / password salah");
            }
        }
    }
}
