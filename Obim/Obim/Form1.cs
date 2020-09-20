using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Obim kruga";
            groupBox1.Text = "Koordinate centra";
            groupBox4.Text = "Koordinate tacke na kruznici";
            button1.Text = "Obim";
            Width = 600;
            Height = 400;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = Convert.ToDouble(textBox1.Text);
                double y0 = Convert.ToDouble(textBox2.Text);
                double x1 = Convert.ToDouble(textBox6.Text);
                double y1 = Convert.ToDouble(textBox7.Text);

                //obrada
                double r;
                r = Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
                double o = 2 * r * Math.PI;
                double o1 = Math.Round(o, 2);

                //izlaz
                MessageBox.Show("Obim: " + o1.ToString());
            }
            catch { MessageBox.Show("Greska!!!\nProverite tacnost unetih podataka"); }
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
