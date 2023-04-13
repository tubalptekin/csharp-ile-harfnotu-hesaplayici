using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.haftaodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v, f, p, o;
            v = Convert.ToInt32(textBox1.Text);
            f=Convert.ToInt32(textBox2.Text);
            p = Convert.ToInt32(textBox3.Text);
            o = (v * 30 / 100) + (f * 50 / 100) + (p * 20 / 100);
            
            switch (o)
            {
                case double ort when ort >= 0 && ort <= 20:
                    label5.Text = "FF";
                    break;
                case double ort when ort >= 21 && ort <= 40:
                    label5.Text = "DD";
                    break;
                case double ort when ort >= 41 && ort <= 60:
                    label5.Text = "CC";
                    break;
                case double ort when ort >= 61 && ort <= 80:
                    label5.Text = "BB";
                    break;
                case double ort when ort >= 81 && ort <= 100:
                    label5.Text = "AA";
                    break;
                default:
                    MessageBox.Show("Lütfen sadece 1-100 arasında not giriniz");
                    break;

            }
            label4.Text = "ortlamanız:" + o;

        }
    }
}
