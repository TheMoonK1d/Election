using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Election
{
    public partial class Supervise : Form
    {
        public Supervise()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            new startingPage().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            new startingPage().Show();
        }

        private void closeIcon_Click_1(object sender, EventArgs e)
        {
            startingPage stp = new startingPage();
            stp.Show();
        }

        private void Supervise_Load(object sender, EventArgs e)
        {
            string conString = "data source = DESKTOP-QN7TIC5\\SQLEXPRESS; database = election; integrated security=SSPI";
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM party", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data_table = new DataTable();
            sda.Fill(data_table);
            dataGridView1.DataSource = data_table;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
