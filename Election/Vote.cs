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
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            new startingPage().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Addis Ababa
            if (comboBox2.SelectedItem == "Addis Ababa")
            {
                label6.Text = "Addis Ababa";
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Afar
            if (comboBox2.SelectedItem == "Afar")
            {
                label6.Text = "Afar";
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Amhara
            if (comboBox2.SelectedItem == "Amhara")
            {
                label6.Text = "Amhara";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Benishangul Gumuz
            if (comboBox2.SelectedItem == "Benishangul Gumuz")
            {
                label6.Text = "Benishangul Gumuz";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Dire Dawa
            if (comboBox2.SelectedItem == "Dire Dawa")
            {
                label6.Text = "Dire Dawa";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Gambela
            if (comboBox2.SelectedItem == "Gambela")
            {
                label6.Text = "Gambela";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Harari
            if (comboBox2.SelectedItem == "Harari")
            {
                label6.Text = "Harari";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Oromia
            if (comboBox2.SelectedItem == "Oromia")
            {
                label6.Text = "Oromia";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Sidama
            if (comboBox2.SelectedItem == "Sidama")
            {
                label6.Text = "Sidama";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //SNNP
            if (comboBox2.SelectedItem == "SNNP")
            {
                label6.Text = "SNNP";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
            //Somali
            if (comboBox2.SelectedItem == "Somali")
            {
                label6.Text = "Somali";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
            }
            //Tigray
            if (comboBox2.SelectedItem == "Tigray")
            {
                label6.Text = "Tigray";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
            }
           
        }

        private void Vote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vote vote = new Vote();
            vote.Close();
            startingPage starting = new startingPage();
            starting.Show();
        }
    }
}
