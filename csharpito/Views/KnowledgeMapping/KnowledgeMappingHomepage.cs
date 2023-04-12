using csharpito.Views.VocacionalTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpito
{
    public partial class KnowledgeMappingHomepage : Form
    {
        public KnowledgeMappingHomepage()
        {
            InitializeComponent();
        }
        private void btnHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }
        private void btnHomePage_Click(object sender, EventArgs e) {
            this.Hide();
            Homepage NewPage = new Homepage();
            NewPage.Show();
        }
        private void btnVocationalTesting_Click(object sender, EventArgs e)
        {
            this.Hide();
            KnowledgeMappingHomepage NewPage = new KnowledgeMappingHomepage();
            NewPage.Show();
        }
        private void btnMeetsRoom_Click(object sender, EventArgs e) {

        }
        private void btnForum_Click(object sender, EventArgs e) {

        }
        private void btnStudentLife_Click(object sender, EventArgs e) {
            this.Hide();
            StudentLifePage NewPage = new StudentLifePage();
            NewPage.Show();
        }

        // LOGICA DO TESTE VOCACIONAL


        private void btnStart_Click(object sender, EventArgs e) {
            this.Hide();
            Question01 NewPage = new Question01();
            NewPage.Show();
        }
        private void btnOut_Click(object sender, EventArgs e) {
            this.Hide();
            SigninPage NewPage = new SigninPage();
            NewPage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
