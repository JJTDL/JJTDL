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
        double markup, sellingprice, costprice, profit, avgcost, totalcostnovat, currentvatcost, margin;
        public double totalavgcost;
        int received;
        DataTable grnd = new DataTable();
        List<CStock> liststock;
        DataTable table;
        string mailmessage, Guid, InvoicNum, passage, internaldoc, supcode;
        string username;
        string connectionString = "Server=agrib_a8; Initial Catalog=LoginSystem; Integrated Security = true";

        public ReceiveStock()
        {
            InitializeComponent();
        }

        private void ReceiveStock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validation check to ensure mandatory fields aren't completely blank
            if (string.IsNullOrWhiteSpace(supplierbox.Text) || string.IsNullOrWhiteSpace(invoicebox.Text))
            {
                MessageBox.Show("Supplier and Invoice Number are required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Prepare the secure parameterized SQL Query
            string query = @"INSERT INTO stock 
                            (Supplier, Invoice_no, Item_description, quantity_received, cost_exc_vat, cost_inc_vat, margin, mark_up, selling_exc_vat, selling_inc_vat) 
                            VALUES 
                            (@Supplier, @InvoiceNo, @ItemDescription, @Quantity, @CostExc, @CostInc, @Margin, @MarkUp, @SellingExc, @SellingInc);";

            // 3. Connect to the database and run the command
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Map Textboxes directly to the parameters (Handles conversion from text to numbers)
                        cmd.Parameters.Add("@Supplier", SqlDbType.VarChar, 150).Value = supplierbox.Text;
                        cmd.Parameters.Add("@InvoiceNo", SqlDbType.VarChar, 50).Value = invoicebox.Text;
                        cmd.Parameters.Add("@ItemDescription", SqlDbType.VarChar, 255).Value = descbox.Text;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = int.Parse(qtyreceived.Text);

                        cmd.Parameters.Add("@CostExc", SqlDbType.Decimal).Value = decimal.Parse(costexcbox.Text);
                        cmd.Parameters.Add("@CostInc", SqlDbType.Decimal).Value = decimal.Parse(costincvat.Text);

                        // Nullable fields check: If user leaves textbox empty, it passes NULL to SQL Server
                        cmd.Parameters.Add("@Margin", SqlDbType.Decimal).Value =
                            string.IsNullOrWhiteSpace("0") ? DBNull.Value : (object)decimal.Parse("0");
                        cmd.Parameters.Add("@MarkUp", SqlDbType.Decimal).Value =
                            string.IsNullOrWhiteSpace("0") ? DBNull.Value : (object)decimal.Parse("0");


                        cmd.Parameters.Add("@SellingExc", SqlDbType.Decimal).Value = decimal.Parse(sellingexc.Text);
                        cmd.Parameters.Add("@SellingInc", SqlDbType.Decimal).Value = decimal.Parse(sellinginc.Text);

                        // Open connection and execute
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Stock item successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optional: Clear the controls after successful entry
                        //   ClearTextBoxes();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Input format error! Please verify that quantities and price amounts are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database rejected entry: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void costincvat_TextChanged(object sender, EventArgs e)
        {
            double d = double.Parse(costincvat.Text) / 1.15;
            costexcbox.Text = d.ToString();
        }

        private void costincvat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
  && !char.IsDigit(e.KeyChar)
  && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void qtyreceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }
        }

        private void sellinginc_TextChanged(object sender, EventArgs e)
        {

            double d = double.Parse(sellinginc.Text)/1.15;
            sellingexc.Text = d.ToString(); 
        }

        private void sellinginc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }
        }
    }
}
