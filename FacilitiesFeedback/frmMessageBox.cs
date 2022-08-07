using System;
using System.Windows.Forms;

namespace FacilitiesFeedback
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox(string message)
        {
            InitializeComponent();
            lbError.Text = message;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
