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
    public partial class Calculator : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operandPerformed)
                txtResult.Clear();

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void Operation(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOperand;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            operand = newOperand;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
