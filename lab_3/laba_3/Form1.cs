using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox3.Text);
            if (x - y == 0)
            {
                double v = (Math.Sin(x) + Math.Cos(y));
                MessageBox.Show("c = " + v.ToString());
            } else if (x - y > 0) {
                double v = Math.Tan(x + y);
                MessageBox.Show("c = " + (v).ToString());
            } else
            {
                double v = Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(y), 2); 
                MessageBox.Show("c = " + (v).ToString());
            }
                  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox3.Text);
            if (x - y == 0)
            {
                double v = (Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Sin(y));
                MessageBox.Show("c = " + v.ToString());
            }
            else if (x - y > 0)
            {
                double v = Math.Pow((x-y), 2) + Math.Cos(y);
                MessageBox.Show("c = " + (v).ToString());
            }
            else
            {
                double v = Math.Pow(x, 2) + Math.Tan(y);
                MessageBox.Show("c = " + (v).ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox3.Text);
            if (x - y == 0)
            {
                double v = (Math.Pow(Math.Sin(x), 2) + Math.Sin(y));
                MessageBox.Show("c = " + v.ToString());
            }
            else if (x - y > 0)
            {
                double v = Math.Cos(x) + Math.Cos(y);
                MessageBox.Show("c = " + (v).ToString());
            }
            else
            {
                double v = y - Math.Pow(Math.Tan(x), 2) + Math.Tan(y);
                MessageBox.Show("c = " + (v).ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
