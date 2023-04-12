using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace csharpito {
    public partial class SigninPage : Form {
       //  MySqlConnection Conn;


        // INITIALIZE
        public SigninPage() {
            InitializeComponent();
        }

        // TO GO SIGNUP
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            SignupPage NewPage = new SignupPage();
            NewPage.Show();
        }

        // INPUT NAME
        private void txtName_TextChanged(object sender, EventArgs e) {

        }

        // INPUT PASSWORD
        private void txtPass_TextChanged(object sender, EventArgs e) {

        }

        // TO GO HOMEPAGE
        private void btnSubmit_Click(object sender, EventArgs e) {

            // CONNECTION WITH DATABASE
            try {
                Database.ConnectionWithDB();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            this.Hide();
            Homepage NewPage = new Homepage();
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

    }
}
