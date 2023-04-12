using csharpito.Views.Trails.AreaFrontend;
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
    public partial class FrontendTrail : Form
    {
        public FrontendTrail()
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

        private void btnVocationalTesting_Click(object sender, EventArgs e) {
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

        private void btnOut_Click(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            trailHTML NewPage = new trailHTML();
            NewPage.Show();
        }

        private void TextTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
