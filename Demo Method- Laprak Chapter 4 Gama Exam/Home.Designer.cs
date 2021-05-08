
namespace Demo_Method__Laprak_Chapter_4_Gama_Exam
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.lblQuestion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Aplikasi Gama Exam";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(51, 93);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login";
            this.lblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogin_LinkClicked);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(51, 132);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(46, 13);
            this.lblRegister.TabIndex = 2;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Register";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(51, 169);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.TabStop = true;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblQuestion_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 304);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.LinkLabel lblQuestion;
    }
}