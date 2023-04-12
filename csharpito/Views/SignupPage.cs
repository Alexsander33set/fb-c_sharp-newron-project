using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csharpito {
    public partial class SignupPage : Form {
        public SignupPage() {
            InitializeComponent();
            Database.ConnectionWithDB();
        }

        private void linkSingIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            SigninPage NewPage = new SigninPage();
            NewPage.Show();
        }

        private void linkTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            TermsOfServicePopup NewPage = new TermsOfServicePopup();
            NewPage.ShowDialog();

        }
        // INPUT USERNAME
        private void txtUser_TextChanged(object sender, EventArgs e) {

        }
        // INPUT EMAIL
        private void txtEmail_TextChanged(object sender, EventArgs e) {

        }
        // INPUT PASSWORD
        private void txtPass_TextChanged(object sender, EventArgs e) {

        }


        /* CRIANDO A LOGICA DO OBJETO SINGUP*/
        private void btnSubmit_Click(object sender, EventArgs e) {
            SigninPage NewPage = new SigninPage();

            // TESTANDO 

            Database.InsertDB(this.txtUser.Text, this.txtPass.Text, txtEmail.Text);
            this.Hide();
            NewPage.Show();
        }

        // TO GO INSTAGRAM
        private void linkInstagram_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/newronn_/");
        }
        // TO GO LINKEDIN
        private void linkLinkedin_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/newron-suporte-b71759243/");
        }
        // INPUT CHECKBOX OF TERMS
        private void checkBoxTerms_CheckedChanged(object sender, EventArgs e) {
            Process.Start("http://www.google.com/");
        }






    }
}
