using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Check_Stock : Form
    {
        private DataTable stockTable = new DataTable();
        private readonly string connectionString = "Server=DESKTOP-FFRLTTD\\SQLEXPRESS; Initial Catalog=LoginSystem; Integrated Security=true";

        public Check_Stock()
        {
            InitializeComponent();
        }

         private void Check_Stock_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Search by item description...";
            textBox1.ForeColor = Color.Gray;

            textBox1.GotFocus += (s, ev) =>
            {
                if (textBox1.Text == "Search by item description...")
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.White;
                }
            };

            textBox1.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "Search by item description...";
                    textBox1.ForeColor = Color.Gray;
                }
            };

            LoadInventoryData(null);
        }
      private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search by item description...") return;
            LoadInventoryData(textBox1.Text);
        }

        private void LoadInventoryData(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_GetStock", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchTerm",
                        string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm);
                    cmd.Parameters.AddWithValue("@LowStockThreshold", 10);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    stockTable = new DataTable();
                    adapter.Fill(stockTable);
                    grdvStock.DataSource = stockTable;

                    // Highlight low stock rows in red — only if the column exists
                    if (grdvStock.Columns.Contains("Stock_Status"))
                    {
                        foreach (DataGridViewRow row in grdvStock.Rows)
                        {
                            var status = row.Cells["Stock_Status"].Value?.ToString();
                            if (string.Equals(status, "LOW STOCK", StringComparison.OrdinalIgnoreCase))
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(80, 20, 20);
                                row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 100, 100);
                            }
                            else if (string.Equals(status, "OUT OF STOCK", StringComparison.OrdinalIgnoreCase))
                            {
                                // optional: visually distinguish out-of-stock
                                row.DefaultCellStyle.BackColor = Color.Gray;
                                row.DefaultCellStyle.ForeColor = Color.White;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       public void ShowFormAndCloseThis(Form nextForm)
        {
            Program.SwitchTo(nextForm, this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmDashboard(""));
        }

        private void Check_Stock_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
