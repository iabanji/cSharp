using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int eventType = 0; // 1 is "plus", 2 is "minus", 3 is "div", 4 is "mult"
        string oldCifer = "0";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int otvet;
            if (eventType == 1)
            {
                otvet = Convert.ToInt32(oldCifer) + Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
                eventType = 0;
            }
            else if (eventType == 2)
            {
                otvet = Convert.ToInt32(oldCifer) - Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
                eventType = 0;
            }
            else if (eventType == 3)
            {
                otvet = Convert.ToInt32(oldCifer) / Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
                eventType = 0;
            }
            else if (eventType == 4)
            {
                otvet = Convert.ToInt32(oldCifer) * Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(otvet);
                eventType = 0;
            }
            else
            {
                MessageBox.Show("Вы не выбрали действие!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            eventType = 1;
            oldCifer = textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            eventType = 0;
            oldCifer = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            eventType = 2;
            oldCifer = textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            eventType = 3;
            oldCifer = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            eventType = 4;
            oldCifer = textBox1.Text;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
