using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCPass_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPass.Text == textBoxCPass.Text)
            {
                labelRight1.Visible = true;
                labelWrong1.Visible = false;
            }
            else
            {
                labelRight1.Visible = false;
                labelWrong1.Visible = true;
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxCPass.Text)
            {
                labelRight1.Visible = true;
                labelWrong1.Visible = false;
            }
            else
            {
                labelRight1.Visible = false;
                labelWrong1.Visible = true;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if(email.Contains("@") && email.Contains("."))
            {
                labelRight2.Visible= true;
                labelWrong2.Visible = false;
            }
            else
            {
                labelRight2.Visible = false;
                labelWrong2.Visible = true;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text;
            if(phone.StartsWith("01") && (phone.Length == 11))
            {
                labelRight3.Visible= true;
                labelWrong3.Visible = false;
            }
            else
            {
                labelRight3.Visible = false;
                labelWrong3.Visible = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxFname.Text != null &&
                textBoxLname.Text != null &&
                textBoxUname.Text != null &&
                textBoxPass.Text != null &&
                textBoxCPass.Text != null &&
                labelRight1.Visible == true &&
                textBoxEmail.Text != null &&
                labelRight2.Visible == true &&
                textBoxPhone.Text != null &&
                labelRight3.Visible == true &&
                (radioButtonMale.Checked || radioButtonFemale.Checked) &&
                comboBox1.Text != null &&
                comboBox1.SelectedItem != null &&
                textBoxAddress.Text != null)
            {
                MessageBox.Show("Registration complete!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check the form again!");
            }

        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
