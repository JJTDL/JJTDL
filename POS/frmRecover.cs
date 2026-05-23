using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmRecover : Form
    {
        public frmRecover()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Please check your email for recovery details and reset options", "Invalid Student Number!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowFormAndCloseThis(new frmLogin());
            }
            else
            {
                MessageBox.Show("Invalid email address!", "Invalid email address!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowFormAndCloseThis(new frmRecover());
            }

        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            nextForm.Show();
            this.Close();
        }

        private void frmRecover_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
