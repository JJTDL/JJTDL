using System.Data;
using System.Data.SqlClient;

namespace POS
{
    public partial class Form1 : Form
    {
        string username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=localhost;Database=agrib_a8;Trusted_Connection=True;TrustServerCertificate=True;");

            string username;
            // string log = "SELECT UserName FROM UserTable WHERE UserName = 'Cardinal'";
            //string log = "SELECT * FROM UserTable WHERE UserName = 'Cardinal'";
            //string log = "select count(*) from Users where Username = '"+UserNameBox.Text.TrimEnd()+"' and Password = "+PasswordBOx.Text.TrimEnd()+"";
            string log = "select count(*) from Users where Username = '" + UserNameBox.Text.TrimEnd() + "'";

            try
            {  // SqlCommand com = new SqlCommand(log, con);
                SqlDataAdapter d1 = new SqlDataAdapter(log, con);
                DataTable dt1 = new DataTable();
                d1.Fill(dt1);
                if (dt1.Rows.Count == 1)
                {
                    username = UserNameBox.Text.TrimEnd();
                    FrontPanel pan1 = new FrontPanel();
                    this.Hide();
                    pan1.Show();
                }
                else
                {
                    MessageBox.Show("Wrong UserName and Password");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Wrong UserName and Password");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
