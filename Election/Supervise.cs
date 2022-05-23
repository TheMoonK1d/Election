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
    }
}
