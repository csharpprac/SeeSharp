using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SwapNames
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "Laur", "Andrew", "Don", "Doru" };


        public Form1()
        {
           
            InitializeComponent();


            //for initialization
            textBox1.Text = names[0]; 
            textBox2.Text = names[1];
            textBox3.Text = names[2];
            textBox4.Text = names[3];

            button2.Enabled = false;


        }

       

        private void button1_Click(object sender, EventArgs e)

        {
            string temp = names[names.Count - 1];
            names.Insert(0, temp);
            names.RemoveAt(names.Count - 1);  
            textBox1.Text = names[0];
            textBox2.Text = names[1];
            textBox3.Text = names[2];
            textBox4.Text = names[3];


        }

        private void button2_Click(object sender, EventArgs e)
        {
   
            //empty the textboxes
            if (checkBox1.Checked)
            {
                textBox1.Text = "";
   
            }
            if (checkBox2.Checked)
            {
                textBox2.Text = "";
           
            }
            if (checkBox3.Checked) {

                textBox3.Text = "";
              
            }
            if (checkBox4.Checked)
            {
                textBox4.Text = "";
            
            }

            //warning upon deleting 
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                MessageBox.Show("One or more boxes are now empty. Click generate to reverse!");

            }
           

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
