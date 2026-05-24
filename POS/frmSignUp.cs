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
    public partial class frmSignUp : Form
    {
        private bool showPassword = false;
        private readonly PasswordEncrypt encryptor = new PasswordEncrypt();
        private readonly string connectionString = "Server=DESKTOP-FFRLTTD\\SQLEXPRESS; Initial Catalog=LoginSystem; Integrated Security=true;";
        public frmSignUp()
        {
            InitializeComponent();
            btnShowPass.Text = showPassword ? "Hide Password🙈" : "Show Password👁";
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            txtPass.UseSystemPasswordChar = !showPassword;
            txtCPass.UseSystemPasswordChar = !showPassword;
            btnShowPass.Text = showPassword ? "Hide Password🙈" : "Show Password👁";
        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            Program.SwitchTo(nextForm, this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUserName?.Text.Trim() ?? string.Empty;
            string name = txtName?.Text.Trim() ?? string.Empty;
            string surname = txtSurname?.Text.Trim() ?? string.Empty;
            string email = txtEmail?.Text.Trim() ?? string.Empty;
            string pass = txtPass?.Text ?? string.Empty;
            string cpass = txtCPass?.Text ?? string.Empty;
            // Basic validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Please enter your surname.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(cpass))
            {
                MessageBox.Show("Please enter and confirm your password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            if (pass != cpass)
            {
                MessageBox.Show("Passwords do not match!", "Password Evaluation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            EvaluatePasswordStrength(pass, out string strength);
            if (strength != "Good")
            {
                // EvaluatePasswordStrength shows user-facing message about weakness
                return;
            }
            string encryptedPassword = encryptor.Encrypt(pass);

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("sp_RegisterUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int result = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            string message = reader.FieldCount > 1 && !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty;

                            MessageBox.Show(message, result == 1 ? "Success" : "Registration", MessageBoxButtons.OK,
                                result == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                            if (result == 1)
                            {
                                // registration successful -> go to login
                                Program.SwitchTo(new frmLogin(), this);
                                return;
                            }

                            // For -1 / -2 or other codes user can correct inputs
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
                MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Validate email format (simple)
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                // simple regex suitable for most cases
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch
            {
                return false;
            }
        }
        public void EvaluatePasswordStrength(string _sInput, out string _sOutput)
        {
            List<string> Numbers = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (_sInput.Length > 8)
            {
                bool has = false;
                _sInput.Split(' ');
                foreach (string num in Numbers)
                {
                    if (_sInput.Contains(num))
                    {
                        has = true;
                    }
                }
                if (has)
                {
                    bool HasUpper = _sInput.Any(char.IsUpper);
                    if (!HasUpper)
                    {
                        MessageBox.Show("Weak Password: Password should include a Upper case character", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _sOutput = "Bad";
                    }
                    else
                        _sOutput = "Good";
                }
                else
                {
                    MessageBox.Show("Weak Password: Password should include a numeric digit", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _sOutput = "Bad";
                }
            }
            else
            {
                MessageBox.Show("Weak Password: Password should be longer than 8 characters", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _sOutput = "Bad";
            }
        }

        private void ilblPssInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("A strong password includes the following:" +
                           " Uppercase Letter, Numeric digit and should " +
                           "be longer than 8 characters", "PASSWORD INFO",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmMain());
        }
    }
}
