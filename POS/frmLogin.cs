using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class frmLogin : Form
    {
        private bool showPassword = false;
        private int loginAttempts = 0;
        private const int MaxAttempts = 3;
        private const int LockoutMinutes = 30;
        private DateTime lockoutEnd = DateTime.MinValue;
        private System.Windows.Forms.Timer lockoutTimer;

        private readonly PasswordEncrypt encryptor = new PasswordEncrypt();
        private readonly string connectionString = "Server=DESKTOP-FFRLTTD\\SQLEXPRESS; Initial Catalog=LoginSystem; Integrated Security=true;";

        public frmLogin()
        {
            InitializeComponent();
            btnShowPass.Text = showPassword ? "Hide Password🙈" : "Show Password👁";
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Check if user is still locked out (in case they reopen the form)
            CheckLockout();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            txtPass.UseSystemPasswordChar = !showPassword;
            btnShowPass.Text = showPassword ? "Hide Password🙈" : "Show Password👁";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check lockout
            if (DateTime.Now < lockoutEnd)
            {
                TimeSpan remaining = lockoutEnd - DateTime.Now;
                MessageBox.Show($"Account locked. Try again in {remaining.Minutes}m {remaining.Seconds}s.",
                    "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUserName.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encrypt the entered password to compare with DB
            string encryptedPassword = encryptor.Encrypt(password);

            if (ValidateLogin(username, encryptedPassword))
            {
                loginAttempts = 0;
                MessageBox.Show($"Welcome, {username}!", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowFormAndCloseThis(new frmDashboard(username));
            }
            else
            {
                loginAttempts++;
                int attemptsLeft = MaxAttempts - loginAttempts;

                if (loginAttempts >= MaxAttempts)
                {
                    // Lock the account
                    lockoutEnd = DateTime.Now.AddMinutes(LockoutMinutes);
                    StartLockoutTimer();
                    MessageBox.Show($"Too many failed attempts!\nYou are locked out for {LockoutMinutes} minutes.",
                        "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowFormAndCloseThis(new frmMain());
                }
                else
                {
                    MessageBox.Show($"Invalid username or password!\n{attemptsLeft} attempt(s) remaining.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateLogin(string username, string encryptedPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_ValidateUser", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            int result = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            return result == 1;
                        }
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void CheckLockout()
        {
            if (DateTime.Now < lockoutEnd)
            {
                StartLockoutTimer();
                btnSubmit.Enabled = false;
            }
        }

        private void StartLockoutTimer()
        {
            btnSubmit.Enabled = false;
            lockoutTimer = new System.Windows.Forms.Timer();
            lockoutTimer.Interval = 1000; // every second
            lockoutTimer.Tick += (s, e) =>
            {
                if (DateTime.Now >= lockoutEnd)
                {
                    lockoutTimer.Stop();
                    btnSubmit.Enabled = true;
                    loginAttempts = 0;
                    MessageBox.Show("Lockout period over. You may try again.",
                        "Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            lockoutTimer.Start();
        }

        public void ShowFormAndCloseThis(Form nextForm)
        {
            Program.SwitchTo(nextForm, this);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ShowFormAndCloseThis(new frmMain());
        }
    }
}