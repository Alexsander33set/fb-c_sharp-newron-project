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
    public partial class Question01 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Question01()
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


        // NAVGATION BAR LINK
        private void btnStudentLife_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLifePage NewPage = new StudentLifePage();
            NewPage.Show();
        }

        private void btnVocationalTesting_Click(object sender, EventArgs e)
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
        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question02 NewPage = new Question02();
            NewPage.Show();
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            this.panel10.BackColor = SystemColors.ControlDark;
        }

        private void askQuestions(int qnum)

        {

            switch (qnum)
            {

                case 1:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 2:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 4:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 5:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 6:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 7:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 8:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 9:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

                case 10:

                    lblQuestion.Text = "i am blue adidadeadd";

                    correctAnswer = 1;

                    break;

            }




        }

        private void card1TextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
