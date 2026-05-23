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
    public partial class frmSignUp : Form
    {
        public bool SH = true;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            SH = !SH;
            txtPass.UseSystemPasswordChar = SH;
        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            nextForm.Show();
            this.Close();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = SH;
        }

        private void txtCPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = SH;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string Username;
            string sOutput;
            if (true)
            {
                string sPass = txtPass.Text;
                string sCPass = txtCPass.Text;
                if (sPass != sCPass)
                {
                    MessageBox.Show("Passwords do not match!", "Password Evaluation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFormAndCloseThis(new frmSignUp());
                }
                else
                {
                    EvaluatePasswordStrength(sPass, out sOutput);
                    if (sOutput == "Good")
                    {
                        //Store data
                        ShowFormAndCloseThis(new frmLogin());//Next form
                    }
                    else
                    {
                        ShowFormAndCloseThis(new frmSignUp());
                    }
                }
            }
        }
        public void EvaluatePasswordStrength(string _sInput, out string _sOutput)
        {
            List<string> Numbers = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (_sInput.Length > 8)
            {
                bool has = false;
                _sInput.Split(' ');
                foreach (string num in Numbers)
                {
                    if (_sInput.Contains(num))
                    {
                        has = true;
                    }
                }
                if (has)
                {
                    bool HasUpper = _sInput.Any(char.IsUpper);
                    if (!HasUpper)
                    {
                        MessageBox.Show("Weak Password: Password should include a Upper case character", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _sOutput = "Bad";
                    }
                    else
                        _sOutput = "Good";
                }
                else
                {
                    MessageBox.Show("Weak Password: Password should include a numeric digit", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _sOutput = "Bad";
                }
            }
            else
            {
                MessageBox.Show("Weak Password: Password should be longer than 8 characters", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _sOutput = "Bad";
            }
        }

        private void ilblPssInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A strong password includes the following:" +
                           " Uppercase Letter, Numeric digit and should " +
                           "be longer than 8 characters", "PASSWORD INFO",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
