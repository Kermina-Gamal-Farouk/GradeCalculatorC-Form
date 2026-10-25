using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)

        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + "%";

            double p = double.Parse(textBox1.Text);
            if (p < 50)
                textBox2.Text = "Fail";
            else if (p >= 50 && p < 65)
                textBox2.Text = "Pass";
            else if (p >= 65 && p < 80)
                textBox2.Text = "Good";
            else if (p >= 80 && p < 90)
                textBox2.Text = "Very Good";
            else if (p >= 90 && p <= 100)
                textBox2.Text = "Excellent";
            else
                MessageBox.Show("Invalid Score");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
