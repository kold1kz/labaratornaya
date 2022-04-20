using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        int polex = 20;
        int poley = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button a = new Button();
            a.Parent = this;
            a.Location = new Point(polex, poley);
            a.Size = new Size(80, 20);
            if (prover() == true)
            {
                polex += 90;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Label b = new Label();
            b.Parent = this;
            b.Text = "что?";
            b.Location = new Point(polex, poley);
            b.Size = new Size(80, 20);
            if (prover() == true)
            {
                polex += 90;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox c = new TextBox();
            c.Parent = this;
            c.Location = new Point(polex, poley);
            c.Size = new Size(80, 20);
            if (prover() == true)
            {
                polex += 90;
            }
        }
        public Boolean prover()
        {
            if (polex > 450 && poley < 410)
            {
                polex = 20;
                poley += 20;
                return false;
            } else if (polex > 450 && poley > 410)
            {
                MessageBox.Show("Места больше нет! \n Запустите прорамму заново!");
                this.Close();
            }
            {
                return true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
