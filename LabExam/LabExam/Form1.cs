using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace LabExam
{
    public partial class Calculator : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double SecondNumber;
        double FirstNumber;
        double result = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "2";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void a5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void a6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void a7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void a8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void a9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void a0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void a10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-" || operandPerformed)
                textBox1.Clear();

            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            operandPerformed = false;
        }

        private void a11_Click(object sender, EventArgs e)
        {

           if (textBox1.Text == "-" || operandPerformed)
                textBox1.Clear();

            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            operandPerformed = false;
        }

        private void a12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "*" || operandPerformed)
                textBox1.Clear();

            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            operandPerformed = false;
        }

        private void a13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "/" || operandPerformed)
                textBox1.Clear();

            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            operandPerformed = false;
        }

        private void a14_Click(object sender, EventArgs e)
        {

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (operand == "+")
            {
                result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(result);
                FirstNumber = result;
            }
            if (operand == "-")
            {
                result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(result);
                FirstNumber = result;
            }
            if (operand == "*")
            {
                result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(result);
                FirstNumber = result;
            }
            if (operand == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(result);
                    FirstNumber = result;
                }
            }
        }
    
    }
}