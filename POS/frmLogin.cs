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
    public partial class frmLogin : Form
    {
        public bool SH = true;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = SH;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            SH = !SH;
            txtPass.UseSystemPasswordChar = SH;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sUsername = "";
            int k = 0;
            string sUserName = txtUserName.Text;
            string sPassword = txtPass.Text;
            if (true)
            {
                //Login
            }
            else
            {
                MessageBox.Show("Username does not exist!\nPlease sign up or recover login your detail ", "Invalid Student Number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowFormAndCloseThis(new frmMain());
            }
        }
        public void ShowFormAndCloseThis(Form nextForm)
        {
            nextForm.Show();
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
