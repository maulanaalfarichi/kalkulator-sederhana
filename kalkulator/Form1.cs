using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int operasi;
        Boolean operasi_seleksi = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(".")))
            {
                textBox1.Text += ".";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            bil1 = 0;
            bil2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operasi = 1;
            operasi_seleksi = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operasi = 2;
            operasi_seleksi = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operasi = 3;
            operasi_seleksi = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operasi = 4;
            operasi_seleksi = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (operasi_seleksi == true)
                bil2 = Convert.ToDecimal(textBox1.Text);
            {
                switch (operasi)
                {
                    case 1:
                        textBox1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        textBox1.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        textBox1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        textBox1.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                operasi_seleksi = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
