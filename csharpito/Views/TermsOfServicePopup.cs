using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csharpito
{
    public partial class TermsOfServicePopup : Form
    {
        public TermsOfServicePopup()
        {
            InitializeComponent();
        }
        private void txtPanelText_TextChanged(object sender, EventArgs e) {

        }
        private void checkBoxTerms_CheckedChanged(object sender, EventArgs e) {

        }
        private void btnCloseTerms_Click(object sender, EventArgs e) {
            this.Hide();
        }

    }
}
