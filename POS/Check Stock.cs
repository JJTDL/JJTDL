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
        DataSet stock = new DataSet();
        public Check_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check_Stock_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView d1 = new DataView(stock.Tables["details"]);
            d1.RowFilter = string.Format("Stock_Description LIKE '%{0}%'", textBox1.Text);
            grdvStock.DataSource = d1;
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
    }
}
