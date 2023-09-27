using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration
{
    public partial class Registration : System.Windows.Forms.Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1Submit_Click(object sender, EventArgs e)
        {
            if (textBox1Fname.Text != null &&
                textBox2Lname.Text != null &&
                textBox3UserName.Text != null &&
                textBox4Pass.Text != null &&
                //label1RightPass.Visible == true &&
                textBox5ConPass != null &&
                label1RightPass.Visible == true &&
                textBox6EmailAdd != null &&
                label3RightEmail.Visible == true &&
                textBox7PhnNum != null &&
                label4RightPhn.Visible == true &&
                (radioButton1Male.Checked || radioButton2Female.Checked) &&
                comboBox1Area.Text != null &&
                comboBox1Area.SelectedItem != null &&
                textBox8Address.Text != null)
            {
                MessageBox.Show("Registration Complete! ");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Check the form again and give the all information");
            }
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new Form();
            f.Show();
        }

        private void textBox4Pass_TextChanged(object sender, EventArgs e)
        {
            if (textBox4Pass.Text == textBox5ConPass.Text)
            {
                label1RightPass.Visible = true;
                label1WrongConPass.Visible = false;
            }
            else
            {
                label1RightPass.Visible = false;
                label1WrongConPass.Visible = true;
            }
        }

        private void textBox5ConPass_TextChanged(object sender, EventArgs e)
        {
            if (textBox4Pass.Text == textBox5ConPass.Text)
            {
                label1RightPass.Visible = true;
                label1WrongConPass.Visible = false;
            }
            else
            {
                label1RightPass.Visible = false;
                label1WrongConPass.Visible = true;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4RoghtPass_Click(object sender, EventArgs e)
        {

        }

        private void textBox6EmailAdd_TextChanged(object sender, EventArgs e)
        {
            string email = textBox6EmailAdd.Text;
            if (email.Contains("@") && email.Contains("."))
            {
                label3RightEmail.Visible = true;
                label3WrongEmail.Visible = false;
            }
            else
            {
                label3RightEmail.Visible = false;
                label3WrongEmail.Visible = true;
            }
        }

        private void textBox7PhnNum_TextChanged(object sender, EventArgs e)
        {
            string phone = textBox7PhnNum.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                label4RightPhn.Visible = true;
                label4WrongPhn.Visible = false;
            }
            else
            {
                label4RightPhn.Visible = false;
                label4WrongPhn.Visible = true;
            }
        }

        private void comboBox1Area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2RightConPass_Click(object sender, EventArgs e)
        {

        }
    }
}
