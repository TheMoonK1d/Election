using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Election
{
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void Vote_Load(object sender, EventArgs e)
        {

        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            new startingPage().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeIcon_Click_1(object sender, EventArgs e)
        {
            startingPage starting_page = new startingPage();
            starting_page.Show();
            this.Close();
        }
    }
}
