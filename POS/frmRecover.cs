using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmRecover : Form
    {
        private readonly string connectionString = "Server=DESKTOP-FFRLTTD\\SQLEXPRESS; Initial Catalog=LoginSystem; Integrated Security=true;";
        public frmRecover()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sEmail = txtEmail?.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(sEmail) || !IsValidEmail(sEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("dbo.sp_RequestPasswordReset", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", sEmail);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            int result = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            string message = reader.FieldCount > 1 && !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty;

                            MessageBox.Show(message, result == 1 ? "Recovery" : "Recovery", MessageBoxButtons.OK,
                                result == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                            if (result == 1)
                            {
                                // On success return user to main (or direct to login)
                                Program.SwitchTo(new frmMain(), this);
                                return;
                            }

                            // If email not found, let user correct it
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Unexpected response from server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Recovery failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            Program.SwitchTo(nextForm, this);
        }
        // Simple regex email validation used in other forms
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch
            {
                return false;
            }
        }

        private void frmRecover_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
