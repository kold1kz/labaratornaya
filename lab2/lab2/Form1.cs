using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class lab2_zadanie3 : Form
    {
        public lab2_zadanie3()
        {
            InitializeComponent();
        }

        private void lab2_zadanie3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z, v;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = double.Parse(textBox3.Text);
            v = double.Parse(textBox4.Text);
            double firstEl = ((1 + Math.Pow(Math.Sin(x + y), 2)) / (Math.Abs(x - ((2 * y) / 1 + Math.Pow(x, 2) * Math.Pow(y, 2)))) * (Math.Pow(x, Math.Abs(y))));
            double secondEl = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
            MessageBox.Show(Math.Round((firstEl + secondEl),4).ToString());
        }
    }
}
