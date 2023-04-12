using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpito.Views.VocacionalTest
{
    public partial class Question02 : Form
    {
        public Question02()
        {
            InitializeComponent();
        }

        // QUESTIONS SELECTS
        private void disagree_MouseLeave(object sender, EventArgs e)
        {
            this.disagreeBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.deselectedBtn));
        }

        private void disagree_MouseHover(object sender, EventArgs e)
        {
            this.disagreeBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.selectedBtn));
        }

        private void agree_MouseLeave(object sender, EventArgs e)
        {
            this.agreeBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.deselectedBtn));
        }

        private void agree_MouseHover(object sender, EventArgs e)
        {
            this.agreeBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.selectedBtn));
        }
        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question03 NewPage = new Question03();
            NewPage.Show();
        }


        // NAVGATION BAR LINK
        private void btnStudentLife_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLifePage NewPage = new StudentLifePage();
            NewPage.Show();
        }

        private void btnKnowledgeMapping_Click(object sender, EventArgs e)
        {
            this.Hide();
            KnowledgeMappingHomepage NewPage = new KnowledgeMappingHomepage();
            NewPage.Show();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage NewPage = new Homepage();
            NewPage.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninPage NewPage = new SigninPage();
            NewPage.Show();
        }
    }
}
