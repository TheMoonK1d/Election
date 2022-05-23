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
    public partial class startingPage : Form
    {
        public startingPage()
        {
            InitializeComponent();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
 
        }

        private void startingPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Vote vote = new Vote();
            vote.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            superviseLogin svl = new superviseLogin();
            svl.Show();
            
        }
    }
}
