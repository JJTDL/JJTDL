using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmDashboard : Form
    {
        private string username;

        public frmDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            Program.SwitchTo(nextForm, this);
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void btnSellAnItem_Click(object sender, EventArgs e)
        {
            Salebox sale = new Salebox(username);
            sale.Show();
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new Check_Stock());
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new ReceiveStock(username));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmMain());
        }
    }
}
