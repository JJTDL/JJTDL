using System.Data;
using System.Data.SqlClient;

namespace POS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmSignUp());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmLogin());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmRecover());
        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            // Use Program.SwitchTo to keep the ApplicationContext.MainForm up-to-date
            Program.SwitchTo(nextForm, this); ;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
