using System.Data;
using System.Data.SqlClient;

namespace POS
{
    public partial class frmMain : Form
    {
        string username, password;
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmSignUp());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmLogin());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public void ShowFormAndCloseThis(Form nextForm)
        {
            nextForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmRecover());
        }
    }
}
