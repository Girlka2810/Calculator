using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double tmp;
        string action = "";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            action = "+";
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (action == "+")
            {
                textBox1.Text = tmp + Convert.ToDouble(textBox1.Text) + "";

            }
            if (action == "-")
            {
                textBox1.Text = tmp - Convert.ToDouble(textBox1.Text) + "";
            }
            if (action == "*")
            {
                textBox1.Text = tmp * Convert.ToDouble(textBox1.Text) + "";
            }
            if (action == "/")
            {
                if (Convert.ToInt32(textBox1.Text) != 0)
                {
                    textBox1.Text = tmp / Convert.ToDouble(textBox1.Text) + "";
                }
            }

        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            action = "-";
        }

        private void myltipleButton_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            action = "*";
        }

        private void deviderButton_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            action = "/";
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;

            
        }

        private void doteButton_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                //if ( )
                //{
                //    textBox1.Text += "0,";
                //}
                //else
                { 
                textBox1.Text += ((Button)sender).Text;
                }
                count = 1;
            }
        }

        private void plusMinus(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double tmp = Convert.ToDouble(textBox1.Text);
                textBox1.Text = tmp * (-1) + "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tmp = 0;
            action = "";
            count = 0;
            textBox1.Text = "";
        }

        private void backspaceButton(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
    }
}
