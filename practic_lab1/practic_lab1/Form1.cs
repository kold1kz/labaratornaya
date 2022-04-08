using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace practic_lab1
{
    public partial class Form1 : Form
    {
        public int[,] polei = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, " + textBox1.Text + "!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 2, 3);
            if (perem == 7)
            {
                button7.Text = "BOOM!";
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.Text = perem.ToString();
                button7.BackColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei , 1, 1);
            if ( perem == 7)
            {
                button2.Text = "BOOM!";
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.Text = perem.ToString();
                button2.BackColor = Color.Blue;
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
   
        private void button11_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            Saper.newgame(ref polei);
            Saper.saper(ref polei);
            button11.Text = "Начать сначала";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button2.Text = "";
            //--------------------------
            button3.BackColor = Color.AntiqueWhite;
            button4.BackColor = Color.AntiqueWhite;
            button5.BackColor = Color.AntiqueWhite;
            button6.BackColor = Color.AntiqueWhite;
            button7.BackColor = Color.AntiqueWhite;
            button8.BackColor = Color.AntiqueWhite;
            button9.BackColor = Color.AntiqueWhite;
            button10.BackColor = Color.AntiqueWhite;
            button2.BackColor = Color.AntiqueWhite;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 3, 3);
            if (perem == 7)
            {
                button10.Text = "BOOM!";
                button10.BackColor = Color.Red;
            }
            else
            {
                button10.Text = perem.ToString();
                button10.BackColor = Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 1, 2);
            if (perem == 7)
            {
                button3.Text = "BOOM!";
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.Text = perem.ToString();
                button3.BackColor = Color.Blue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 1, 3);
            if (perem == 7)
            {
                button4.Text = "BOOM!";
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.Text = perem.ToString();
                button4.BackColor = Color.Blue;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 2, 1);
            if (perem == 7)
            {
                button5.Text = "BOOM!";
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.Text = perem.ToString();
                button5.BackColor = Color.Blue;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 2, 2);
            if (perem == 7)
            {
                button6.Text = "BOOM!";
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.Text = perem.ToString();
                button6.BackColor = Color.Blue;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 3, 1);
            if (perem == 7)
            {
                button8.Text = "BOOM!";
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.Text = perem.ToString();
                button8.BackColor = Color.Blue;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Saper Saper = new Saper();
            int perem = Saper.Sosed(polei, 3, 2);
            if (perem == 7)
            {
                button9.Text = "BOOM!";
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.Text = perem.ToString();
                button9.BackColor = Color.Blue;
            }
        }
    }
    public class Saper
    {
        public int[,] poley;
       // = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

        public void saper(ref int[,] polei)
        {
            while (add(polei) < 3) { add(polei); }
        }

        public void newgame(ref int[,] polei)
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    polei[i, j] = 0;
                }
            }
        }
        public int Sosed(int[,] polei, int a, int b)
        {
            int sosed = 0;
            if (polei[a, b] != 8)
            {
                for (int i = a - 1; i < a + 2; i++)
                {
                    for (int j = b - 1; j < b + 2; j++)
                    {
                        if (polei[i, j] == 8)
                        {
                            sosed++;
                        }
                    }
                }
            }
            else
            {
                sosed = 7;
            }

            return sosed;
        }

        int add(int[,] polei)
        {
            Random rnd = new Random();
            int check = 0;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    int q = rnd.Next(2);
                    if (check >= 3)
                    {
                        break;
                    }
                    if (q == 1)
                    {
                        polei[i, j] = 8;
                        check++;
                    }
                }
            }
            return check;
        }
    }
}
