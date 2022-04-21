using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = "";
            String c = "";
            int ch = 0;
            int prob = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    prob++;
                }
            }
            if (prob == 1)
            {
                a = a + " ";
            }
            for (int i =0; i < a.Length ; i++)
            {
                if (a[i] == ' ')
                {
                    if (ch < 1)
                    {
                        ch++; //hi carl man | carl hi hi carl man
                        c = b;
                        b = "";
                    } else {
                        a = a.Remove(0, i);
                        break;
                    }
                    
                } else
                {
                    b += a[i];
                }
            }
            textBox1.Text = (b + " " + c + a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
