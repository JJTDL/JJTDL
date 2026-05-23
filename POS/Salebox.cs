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
        public Salebox()
        {
            InitializeComponent();
        }

        private void Salebox_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            // 1. Define your connection string (update with your actual server credentials)
            string connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;";

            // 2. Write the SQL query to pull the form data
            string query = @"select * from Stock";

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
                   dataGridView1.DataSource = dataTable;
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
