using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormWithCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string query = "UPDATE new_table SET first_name = @FirstName, last_name = @LastName, phone = @Phone, email = @Email WHERE id = @ID";

            using (MySqlConnection conn = new MySqlConnection(connection))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                // Use parameterized queries to prevent SQL injection
                cmd.Parameters.AddWithValue("@FirstName", this.first_name.Text);
                cmd.Parameters.AddWithValue("@LastName", this.last_name.Text);
                cmd.Parameters.AddWithValue("@Phone", this.phone.Text);
                cmd.Parameters.AddWithValue("@Email", this.email.Text);
                cmd.Parameters.AddWithValue("@ID", this.ID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data was updated.");
                }
                else
                {
                    MessageBox.Show("Data Update Failed.");
                }
            }
        }


        private void btnADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string query = "INSERT INTO new_table (first_name, last_name, phone, email) " +
                           "VALUES (@FirstName, @LastName, @Phone, @Email)";

            using (MySqlConnection conn = new MySqlConnection(connection))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                // Use parameterized queries to prevent SQL injection
                cmd.Parameters.AddWithValue("@FirstName", this.first_name.Text);
                cmd.Parameters.AddWithValue("@LastName", this.last_name.Text);
                cmd.Parameters.AddWithValue("@Phone", this.phone.Text);
                cmd.Parameters.AddWithValue("@Email", this.email.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Successfully Added.");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed.");
                }
            }
        }


        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string query = "DELETE FROM new_table WHERE id = @ID";

            using (MySqlConnection conn = new MySqlConnection(connection))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                // Use parameterized queries to prevent SQL injection
                cmd.Parameters.AddWithValue("@ID", this.ID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data has been deleted.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed.");
                }
            }
        }


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string query = "SELECT * FROM new_table";

            using (MySqlConnection conn = new MySqlConnection(connection))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
