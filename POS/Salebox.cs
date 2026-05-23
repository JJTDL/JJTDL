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
        DataSet stock = new DataSet();

        public Salebox(string username)
        {

            InitializeComponent();
        }

        private void Salebox_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            // grdselectedstock.Columns.Clear();

            // 2. Loop through all columns in grid 1, clone them, and add them to grid 2
            foreach (DataGridViewColumn col in grdvStock.Columns)
            {
                grdselectedstock.Columns.Add((DataGridViewColumn)col.Clone());
            }
        }

        private void LoadInventoryData()
        {
            // 1. Define your connection string (update with your actual server credentials)
            string connectionString = "Server=agrib_a8; Initial Catalog=LoginSystem; Integrated Security = true";

            // 2. Write the SQL query to pull the form data
            // string query = @"select * from Stock";
            string query = "select [StockId] As ID     ,[Supplier]      ,[Invoice_no] as Invoice_Num     ,[Item_description] as Item_Description      ,[quantity_received] as Qty_Received\r\n      ,[cost_exc_vat] as Cost_Exc_Vat     ,[cost_inc_vat] as Cost_Inc_vat\r\n      ,[margin] as Margin\r\n      ,[mark_up] as Mark_up\r\n      ,[selling_exc_vat] as Selling_Exc_Vat    ,[selling_inc_vat] as Selling_Inc_Vat FROM [LoginSystem].[dbo].[Stock]";
            // 3. Establish connection and fetch data using a 'using' block to cleanly close resources
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Use a DataAdapter to execute the query and manage the connection
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Create an in-memory table to hold the results
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the database records
                    adapter.Fill(dataTable);

                    // 4. Bind the data table straight to your DataGridView UI component
                    grdvStock.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Helpful if something snaps (like a typo in the connection string)
                    MessageBox.Show($"Oops! Something went wrong loading the data: {ex.Message}",
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView d1 = new DataView(stock.Tables["details"]);
            d1.RowFilter = string.Format("Stock_Description LIKE '%{0}%'", textBox1.Text);
            grdvStock.DataSource = d1;
        }

        private void grdvStock_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                // 1. Get the unique StockId of the item the user double-clicked
                string targetStockId = grdvStock.Rows[e.RowIndex].Cells[0].Value.ToString();

                bool itemExists = false;

                // 2. Search through dataGridView2 to see if this StockId is already in there
                foreach (DataGridViewRow row in grdselectedstock.Rows)
                {
                    // Ensure the row isn't the blank "new row" line at the bottom
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == targetStockId)
                    {
                        // ITEM FOUND! 
                        // Read the current quantity from Column Index 4 (quantity_received)
                        int currentQty = Convert.ToInt32(row.Cells[4].Value);

                        // Increment it by 1
                        row.Cells[4].Value = currentQty + 1;

                        itemExists = true;
                        break; // Stop looking through the rest of the rows
                    }
                }

                // 3. ITEM NOT FOUND: Add it fresh
                if (!itemExists)
                {
                    // Create the new row
                    int newRowIndex = grdselectedstock.Rows.Add();
                    DataGridViewRow clickedRow = grdvStock.Rows[e.RowIndex];

                    // Copy all data columns over from grid 1 to grid 2
                    for (int i = 0; i < clickedRow.Cells.Count; i++)
                    {
                        grdselectedstock.Rows[newRowIndex].Cells[i].Value = clickedRow.Cells[i].Value;
                    }

                    // FORCE the quantity column (Index 4) to be exactly 1 always on first add
                    grdselectedstock.Rows[newRowIndex].Cells[4].Value = 1;
                }
            }


            /* if (e.RowIndex >= 0)
             {
                 // 1. Get the specific row that was double-clicked
                 DataGridViewRow clickedRow = grdvStock.Rows[e.RowIndex];

                 // 2. Add a new blank row to the second grid
                 int newRowIndex = grdselectedstock.Rows.Add();

                 // 3. Copy the cell values over one by one
                 for (int i = 0; i < clickedRow.Cells.Count; i++)
                 {
                     grdselectedstock.Rows[newRowIndex].Cells[i].Value = clickedRow.Cells[i].Value;
                 }
            */
            // 4. [OPTIONAL] Remove the row from the first grid if you want a "MOVE" effect
            // dataGridView1.Rows.RemoveAt(e.RowIndex);

        }

        private void grdvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  if (e.RowIndex >= 0)
              {
                  // 1. Get the unique StockId of the item the user double-clicked
                  string targetStockId = grdvStock.Rows[e.RowIndex].Cells[0].Value.ToString();

                  bool itemExists = false;

                  // 2. Search through dataGridView2 to see if this StockId is already in there
                  foreach (DataGridViewRow row in grdselectedstock.Rows)
                  {
                      // Ensure the row isn't the blank "new row" line at the bottom
                      if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == targetStockId)
                      {
                          // ITEM FOUND! 
                          // Read the current quantity from Column Index 4 (quantity_received)
                          int currentQty = Convert.ToInt32(row.Cells[4].Value);

                          // Increment it by 1
                          row.Cells[4].Value = currentQty + 1;

                          itemExists = true;
                          break; // Stop looking through the rest of the rows
                      }

                  }

                  // 3. ITEM NOT FOUND: Add it fresh
                  if (!itemExists)
                  {
                      // Create the new row
                      int newRowIndex = grdselectedstock.Rows.Add();
                      DataGridViewRow clickedRow = grdvStock.Rows[e.RowIndex];

                      // Copy all data columns over from grid 1 to grid 2
                      for (int i = 0; i < 10; i++)
                      {
                          grdselectedstock.Rows[newRowIndex].Cells[i].Value = clickedRow.Cells[i].Value;

                      }

                      // FORCE the quantity column (Index 4) to be exactly 1 always on first add
                      grdselectedstock.Rows[newRowIndex].Cells[4].Value = 1;

                  }
              }
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Check if the cart is completely empty before doing anything
            if (grdselectedstock.Rows.Count == 0 || (grdselectedstock.Rows.Count == 1 && grdselectedstock.Rows[0].IsNewRow))
            {
                MessageBox.Show("The cart is empty. There are no items to sell.", "Checkout Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Your exact connection string setup
            // string connectionString = "Server=localhost; Initial Catalog=agrib_a8; Integrated Security = true; TrustServerCertificate = True;";
            string connectionString = "Server=agrib_a8; Initial Catalog=LoginSystem; Integrated Security = true";

            // SQL query to subtract the sold quantity from the existing quantity in the database
            string query = "UPDATE stock SET quantity_received = quantity_received - @SoldQty WHERE StockId = @StockId;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Start a transaction to process all items safely as a single batch
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                        {
                            try
                            {
                                // 2. Loop through every row in your sales cart (dataGridView2)
                                foreach (DataGridViewRow row in grdselectedstock.Rows)
                                {
                                    // Skip the blank row placeholder at the very bottom of the grid
                                    if (row.IsNewRow) continue;

                                    // Ensure cells actually contain data
                                    if (row.Cells[0].Value != null && row.Cells[4].Value != null)
                                    {
                                        int stockId = Convert.ToInt32(row.Cells[0].Value);
                                        int soldQty = Convert.ToInt32(row.Cells[4].Value);

                                        // Clear parameters from the last loop iteration to avoid duplicate errors
                                        cmd.Parameters.Clear();

                                        // Bind the current row's data to the SQL update command
                                        cmd.Parameters.Add("@SoldQty", SqlDbType.Int).Value = soldQty;
                                        cmd.Parameters.Add("@StockId", SqlDbType.Int).Value = stockId;

                                        // Run the update for this row
                                        cmd.ExecuteNonQuery();
                                    }
                                }

                                // 3. If the loop completes with absolutely no errors, save changes permanently
                                transaction.Commit();

                                MessageBox.Show("Sale completed successfully! Stock levels updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the sales cart grid so it is ready for the next customer
                                grdselectedstock.Rows.Clear();
                                LoadInventoryData();
                            }
                            catch (Exception ex)
                            {
                                // Something failed mid-process. Roll back the database to exactly how it looked before the button click.
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred during processing. No changes were saved.\nDetails: {ex.Message}", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not connect to the database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. Get the unique StockId of the item the user double-clicked
                string targetStockId = grdvStock.Rows[e.RowIndex].Cells[0].Value.ToString();

                bool itemExists = false;

                // 2. Search through dataGridView2 to see if this StockId is already in there
                foreach (DataGridViewRow row in grdselectedstock.Rows)
                {
                    // Ensure the row isn't the blank "new row" line at the bottom
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == targetStockId)
                    {
                        // ITEM FOUND! 
                        // Read the current quantity from Column Index 4 (quantity_received)
                        int currentQty = Convert.ToInt32(row.Cells[4].Value);

                        // Increment it by 1
                        row.Cells[4].Value = currentQty + 1;

                        itemExists = true;
                        break; // Stop looking through the rest of the rows
                    }

                }

                // 3. ITEM NOT FOUND: Add it fresh
                if (!itemExists)
                {
                    // Create the new row
                    int newRowIndex = grdselectedstock.Rows.Add();
                    DataGridViewRow clickedRow = grdvStock.Rows[e.RowIndex];

                    // Copy all data columns over from grid 1 to grid 2
                    for (int i = 0; i < 11; i++)
                    {
                        grdselectedstock.Rows[newRowIndex].Cells[i].Value = clickedRow.Cells[i].Value;

                    }

                    // FORCE the quantity column (Index 4) to be exactly 1 always on first add
                    grdselectedstock.Rows[newRowIndex].Cells[4].Value = 1;

                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Check if the cart is completely empty before doing anything
            if (grdselectedstock.Rows.Count == 0 || (grdselectedstock.Rows.Count == 1 && grdselectedstock.Rows[0].IsNewRow))
            {
                MessageBox.Show("The cart is empty. There are no items to sell.", "Checkout Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Your exact connection string setup
            // string connectionString = "Server=localhost; Initial Catalog=agrib_a8; Integrated Security = true; TrustServerCertificate = True;";
            string connectionString = "Server=agrib_a8; Initial Catalog=LoginSystem; Integrated Security = true";

            // SQL query to subtract the sold quantity from the existing quantity in the database
            string query = "UPDATE stock SET quantity_received = quantity_received - @SoldQty WHERE StockId = @StockId;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Start a transaction to process all items safely as a single batch
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                        {
                            try
                            {
                                // 2. Loop through every row in your sales cart (dataGridView2)
                                foreach (DataGridViewRow row in grdselectedstock.Rows)
                                {
                                    // Skip the blank row placeholder at the very bottom of the grid
                                    if (row.IsNewRow) continue;

                                    // Ensure cells actually contain data
                                    if (row.Cells[0].Value != null && row.Cells[4].Value != null)
                                    {
                                        int stockId = Convert.ToInt32(row.Cells[0].Value);
                                        int soldQty = Convert.ToInt32(row.Cells[4].Value);

                                        // Clear parameters from the last loop iteration to avoid duplicate errors
                                        cmd.Parameters.Clear();

                                        // Bind the current row's data to the SQL update command
                                        cmd.Parameters.Add("@SoldQty", SqlDbType.Int).Value = soldQty;
                                        cmd.Parameters.Add("@StockId", SqlDbType.Int).Value = stockId;

                                        // Run the update for this row
                                        cmd.ExecuteNonQuery();
                                    }
                                }

                                // 3. If the loop completes with absolutely no errors, save changes permanently
                                transaction.Commit();

                                MessageBox.Show("Sale completed successfully! Stock levels updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // string receipt = ProcessSale(grdselectedstock.Rows);
                                string receipt = ProcessSaleWithoutTransaction(grdselectedstock.Rows);
                                MessageBox.Show($"Transaction saved successfully!\nReceipt: {receipt}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the sales cart grid so it is ready for the next customer
                                grdselectedstock.Rows.Clear();
                                LoadInventoryData();
                            }


                            catch (Exception ex)
                            {
                                // Something failed mid-process. Roll back the database to exactly how it looked before the button click.
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred during processing. No changes were saved.\nDetails: {ex.Message}", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not connect to the database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salexitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ProcessSale(DataGridViewRowCollection cartRows)
        {
            string connectionString = "Server=agrib_a8; Initial Catalog=LoginSystem; Integrated Security = true";


            // Generate the unique receipt number string
            string receiptNumber = "REC-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            string updateStockQuery = "UPDATE stock SET quantity_received = quantity_received - @SoldQty WHERE StockId = @StockId;";
            string insertTxQuery = @"INSERT INTO SalesTransactions (ReceiptNumber, StockId, QuantitySold, PriceSoldAt) 
                             VALUES (@Receipt, @StockId, @SoldQty, @Price);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    using (SqlCommand cmdUpdate = new SqlCommand(updateStockQuery, conn, transaction))
                    using (SqlCommand cmdInsert = new SqlCommand(insertTxQuery, conn, transaction))
                    {
                        // Pre-add parameters to optimize data loop speeds
                        cmdUpdate.Parameters.Add("@SoldQty", SqlDbType.Int);
                        cmdUpdate.Parameters.Add("@StockId", SqlDbType.Int);

                        cmdInsert.Parameters.Add("@Receipt", SqlDbType.VarChar, 50).Value = receiptNumber;
                        cmdInsert.Parameters.Add("@StockId", SqlDbType.Int);
                        cmdInsert.Parameters.Add("@SoldQty", SqlDbType.Int);
                        cmdInsert.Parameters.Add("@Price", SqlDbType.Decimal);

                        try
                        {
                            foreach (DataGridViewRow row in cartRows)
                            {
                                if (row.IsNewRow) continue;

                                if (row.Cells[0].Value != null && row.Cells[4].Value != null)
                                {
                                    int stockId = Convert.ToInt32(row.Cells[0].Value);
                                    int soldQty = Convert.ToInt32(row.Cells[4].Value);
                                    decimal priceSoldAt = Convert.ToDecimal(row.Cells[10].Value); // Column 10: selling_inc_vat

                                    // Bind current values and run the update
                                    cmdUpdate.Parameters["@SoldQty"].Value = soldQty;
                                    cmdUpdate.Parameters["@StockId"].Value = stockId;
                                    cmdUpdate.ExecuteNonQuery();

                                    // Bind current values and run the record entry
                                    cmdInsert.Parameters["@StockId"].Value = stockId;
                                    cmdInsert.Parameters["@SoldQty"].Value = soldQty;
                                    cmdInsert.Parameters["@Price"].Value = priceSoldAt;
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }

                            // Save transaction batch
                            transaction.Commit();
                            return receiptNumber;
                        }
                        catch (Exception)
                        {
                            // Roll back data changes and pass the error back up to the UI layer
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }

        private string ProcessSaleWithoutTransaction(DataGridViewRowCollection cartRows)
        {
            string connectionString = "Server=agrib_a8; Initial Catalog=LoginSystem; Integrated Security = true";

            string receiptNumber = "REC-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            string updateStockQuery = "UPDATE stock SET quantity_received = quantity_received - @SoldQty WHERE StockId = @StockId;";
            // string insertTxQuery = @"INSERT INTO SalesTransactions (ReceiptNumber, StockId, QuantitySold, PriceSoldAt) VALUES (@Receipt, @StockId, @SoldQty, @Price);";
            string insertTxQuery = @"INSERT INTO SalesTransactions (ReceiptNumber, StockId, QuantitySold, PriceSoldAt, Description) 
                         VALUES (@Receipt, @StockId, @SoldQty, @Price, @Description);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Notice: Commands are linked directly to the connection now, no transaction object involved
                using (SqlCommand cmdUpdate = new SqlCommand(updateStockQuery, conn))
                using (SqlCommand cmdInsert = new SqlCommand(insertTxQuery, conn))
                {
                    cmdUpdate.Parameters.Add("@SoldQty", SqlDbType.Int);
                    cmdUpdate.Parameters.Add("@StockId", SqlDbType.Int);
                    cmdInsert.Parameters.Add("@Description", SqlDbType.VarChar, 255);
                    cmdInsert.Parameters.Add("@Receipt", SqlDbType.VarChar, 50).Value = receiptNumber;
                    cmdInsert.Parameters.Add("@StockId", SqlDbType.Int);
                    cmdInsert.Parameters.Add("@SoldQty", SqlDbType.Int);
                    cmdInsert.Parameters.Add("@Price", SqlDbType.Decimal);

                    // Every item executes independently instantly
                    foreach (DataGridViewRow row in cartRows)
                    {
                        if (row.IsNewRow) continue;

                        if (row.Cells[0].Value != null && row.Cells[4].Value != null)
                        {
                            int stockId = Convert.ToInt32(row.Cells[0].Value);
                            int soldQty = Convert.ToInt32(row.Cells[4].Value);
                            decimal priceSoldAt = Convert.ToDecimal(row.Cells[10].Value);
                            string itemDescription = row.Cells["Item_description"].Value?.ToString() ?? "No Description";

                            // Update Stock table row immediately
                            cmdUpdate.Parameters["@SoldQty"].Value = soldQty;
                            cmdUpdate.Parameters["@StockId"].Value = stockId;
                            cmdInsert.Parameters["@Description"].Value = itemDescription;
                            cmdUpdate.ExecuteNonQuery();

                            // Insert Transaction table row immediately
                            cmdInsert.Parameters["@StockId"].Value = stockId;
                            cmdInsert.Parameters["@SoldQty"].Value = soldQty;
                            cmdInsert.Parameters["@Price"].Value = priceSoldAt;
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }
            }
            return receiptNumber;
        }


    }
}


