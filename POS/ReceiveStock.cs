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
    public partial class ReceiveStock : Form
    {
        private string username;
        private readonly string connectionString = "Server=DESKTOP-FFRLTTD\\SQLEXPRESS; Initial Catalog=LoginSystem; Integrated Security=true";

        public ReceiveStock(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ReceiveStock_Load(object sender, EventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(supplierbox.Text) || string.IsNullOrWhiteSpace(invoicebox.Text))
            {
                MessageBox.Show("Supplier and Invoice Number are required fields!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse numbers safely
            if (!int.TryParse(qtyreceived.Text, out int quantity) ||
                !decimal.TryParse(costincvat.Text, out decimal costInc) ||
                !decimal.TryParse(costexcbox.Text, out decimal costExc) ||
                !decimal.TryParse(sellinginc.Text, out decimal sellingInc) ||
                !decimal.TryParse(sellingexc.Text, out decimal sellingExc))
            {
                MessageBox.Show("Please make sure all numeric fields contain valid numbers.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"INSERT INTO Stock 
                (Supplier, Invoice_no, Item_description, quantity_received, 
                 cost_exc_vat, cost_inc_vat, margin, mark_up, selling_exc_vat, selling_inc_vat) 
                VALUES 
                (@Supplier, @InvoiceNo, @ItemDescription, @Quantity, 
                 @CostExc, @CostInc, @Margin, @MarkUp, @SellingExc, @SellingInc);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.Add("@Supplier", SqlDbType.VarChar, 150).Value = supplierbox.Text;
                    cmd.Parameters.Add("@InvoiceNo", SqlDbType.VarChar, 50).Value = invoicebox.Text;
                    cmd.Parameters.Add("@ItemDescription", SqlDbType.VarChar, 255).Value = descbox.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                    cmd.Parameters.Add("@CostExc", SqlDbType.Decimal).Value = costExc;
                    cmd.Parameters.Add("@CostInc", SqlDbType.Decimal).Value = costInc;
                    cmd.Parameters.Add("@Margin", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@MarkUp", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@SellingExc", SqlDbType.Decimal).Value = sellingExc;
                    cmd.Parameters.Add("@SellingInc", SqlDbType.Decimal).Value = sellingInc;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Stock item successfully recorded!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── Auto-calculate Exc VAT from Inc VAT ─────────────────
        private void costincvat_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(costincvat.Text, out double d))
                costexcbox.Text = (d / 1.15).ToString("F2");
        }

        private void sellinginc_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(sellinginc.Text, out double d))
                sellingexc.Text = (d / 1.15).ToString("F2");
        }

        private void costincvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }

        private void sellinginc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }

        private void qtyreceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
        private void ClearFields()
        {
            supplierbox.Clear();
            invoicebox.Clear();
            descbox.Clear();
            qtyreceived.Clear();
            costincvat.Clear();
            costexcbox.Clear();
            sellinginc.Clear();
            sellingexc.Clear();
        }
        public void ShowFormAndCloseThis(Form nextForm)
        {
            Program.SwitchTo(nextForm, this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmDashboard(username));
        }

        private void ReceiveStock_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void invoicebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmDashboard(username));
        }
    }
}
