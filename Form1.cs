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
            string querry = "UPDATE new_table SET first_name = '"+this.first_name.Text+ "', last_name = '"+this.last_name.Text+ "',phone = '"+this.phone.Text+ "',email = '"+this.email.Text+ "' WHERE id = '"+this.ID.Text+"' ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            conn.Open();
            _ = cmd.ExecuteReader();
            MessageBox.Show("Data was updated.");
            conn.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string querry = "INSERT INTO new_table" +
                "(first_name, last_name, phone, email)" +
                "VALUES(" +
                "'"+this.first_name.Text+ "'," +
                "'"+this.last_name.Text+ "'," +
                "'"+this.phone.Text+ "'," +
                "'"+this.email.Text+"')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            conn.Open();
            _ = cmd.ExecuteReader();
            MessageBox.Show("Data Successfully Added.");
            conn.Close();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string querry = "DELETE FROM new_table WHERE id='"+this.ID.Text+"' ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            conn.Open();
            _ = cmd.ExecuteReader();
            MessageBox.Show("Data has been deleted.");
            conn.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost; user id=root; password=password; database=mydb";
            string querry = "SELECT * FROM mydb.new_table";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(querry, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
