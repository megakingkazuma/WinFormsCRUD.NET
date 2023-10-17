using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormWithCRUD
{
    public partial class LoginForm : Form
    {
        DB DB = new DB();
        private MySqlConnection conn; // Declare MySqlConnection at the class level

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.input_username.Text))
            {
                MessageBox.Show("Please enter username.","Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.input_username.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.input_password.Text))
            {
                MessageBox.Show("Please enter password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.input_password.Focus();
                return;
            }
            string query = "SELECT COUNT(*) FROM mydb.logincredentials WHERE username = @Username AND password = @Password";

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString()))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Username", this.input_username.Text);
                cmd.Parameters.AddWithValue("@Password", this.input_password.Text);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result > 0)
                {
                    // Successful login
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.");
                }
            }
   
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
