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
    public partial class superviseLogin : Form
    {
        public superviseLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {

                Console.WriteLine("Username correct");
                if (textBox2.Text == "root")
                {
                    Console.WriteLine("Passowrd correct");
                    Supervise supervise = new Supervise();
                    supervise.Show();
                    this.Close();
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Wrong Username");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
