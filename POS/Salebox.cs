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
    public partial class Salebox : Form
    {
        private DataTable stockTable = new DataTable();
        private string username;
        private readonly string connectionString = "Server=DESKTOP-FFRLTTD\\SQLEXPRESS; Initial Catalog=LoginSystem; Integrated Security=true;";

        public Salebox(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Salebox_Load(object sender, EventArgs e)
        {
            LoadInventoryData();

            // Mirror columns from stock grid into cart grid
            grdselectedstock.Columns.Clear();
            foreach (DataGridViewColumn col in grdvStock.Columns)
                grdselectedstock.Columns.Add((DataGridViewColumn)col.Clone());
        }

        private void LoadInventoryData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.sp_GetStock", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    stockTable = new DataTable();
                    adapter.Fill(stockTable);
                    grdvStock.DataSource = stockTable;

                    // Highlight low stock rows
                    foreach (DataGridViewRow row in grdvStock.Rows)
                    {
                        if (row.Cells["Qty_Received"].Value != null &&
                            int.TryParse(row.Cells["Qty_Received"].Value.ToString(), out int q) &&
                            q <= 10)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(80, 20, 20);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 100, 100);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading stock: {ex.Message}",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (stockTable == null) return;
            DataView dv = new DataView(stockTable);
            // sanitize input for filter by escaping single quotes
            string filter = textBox1.Text.Replace("'", "''");
            dv.RowFilter = $"Item_Description LIKE '%{filter}%'";
            grdvStock.DataSource = dv;
        }

        private void grdvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string targetStockId = grdvStock.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(targetStockId)) return;

            bool itemExists = false;

            // If already in cart, increment quantity
            foreach (DataGridViewRow row in grdselectedstock.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == targetStockId)
                {
                    if (int.TryParse(row.Cells[4].Value?.ToString(), out int currentQty))
                        row.Cells[4].Value = currentQty + 1;
                    else
                        row.Cells[4].Value = 1;

                    itemExists = true;
                    break;
                }
            }

            // Otherwise add fresh row with quantity 1
            if (!itemExists)
            {
                int newRowIndex = grdselectedstock.Rows.Add();
                DataGridViewRow clickedRow = grdvStock.Rows[e.RowIndex];

                for (int i = 0; i < clickedRow.Cells.Count && i < grdselectedstock.Columns.Count; i++)
                    grdselectedstock.Rows[newRowIndex].Cells[i].Value = clickedRow.Cells[i].Value;

                if (grdselectedstock.Columns.Count > 4)
                    grdselectedstock.Rows[newRowIndex].Cells[4].Value = 1;
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (grdselectedstock.Rows.Count == 0 ||
               (grdselectedstock.Rows.Count == 1 && grdselectedstock.Rows[0].IsNewRow))
            {
                MessageBox.Show("The cart is empty. There are no items to sell.",
                    "Checkout Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string receiptNumber = ProcessSale(grdselectedstock.Rows);
                if (!string.IsNullOrEmpty(receiptNumber))
                {
                    MessageBox.Show($"Sale completed!\nReceipt: {receiptNumber}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    grdselectedstock.Rows.Clear();
                    LoadInventoryData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sale failed: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ProcessSale(DataGridViewRowCollection cartRows)
        {
            string receiptNumber = "REC-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            DataTable itemsTable = new DataTable();
            itemsTable.Columns.Add("StockId", typeof(int));
            itemsTable.Columns.Add("SoldQty", typeof(int));
            itemsTable.Columns.Add("Price", typeof(decimal));
            itemsTable.Columns.Add("Description", typeof(string));

            foreach (DataGridViewRow row in cartRows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[0].Value == null || row.Cells[4].Value == null) continue;

                if (!int.TryParse(row.Cells[0].Value.ToString(), out int stockId)) continue;
                if (!int.TryParse(row.Cells[4].Value?.ToString(), out int soldQty)) continue;

                decimal price = 0m;
                if (row.Cells.Count > 10 && row.Cells[10].Value != null)
                    decimal.TryParse(row.Cells[10].Value.ToString(), out price);
                else if (row.Cells.Count > 5 && row.Cells[5].Value != null)
                    decimal.TryParse(row.Cells[5].Value.ToString(), out price);

                string description = row.Cells["Item_Description"]?.Value?.ToString() ?? (row.Cells.Count > 3 ? row.Cells[3].Value?.ToString() : "No Description");

                itemsTable.Rows.Add(stockId, soldQty, price, description);
            }

            if (itemsTable.Rows.Count == 0)
                throw new InvalidOperationException("No sellable items found.");

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.sp_ProcessSale", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Receipt", receiptNumber);

                var tvp = cmd.Parameters.AddWithValue("@Items", itemsTable);
                tvp.SqlDbType = SqlDbType.Structured;
                tvp.TypeName = "dbo.SaleItemType";

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int result = reader.IsDBNull(0) ? -1 : reader.GetInt32(0);
                        string message = reader.FieldCount > 1 && !reader.IsDBNull(1) ? reader.GetString(1) : null;
                        if (result == 1) return receiptNumber;
                        throw new InvalidOperationException(message ?? "Server rejected sale.");
                    }
                }
            }
            return null;
        }

        private void salexitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


