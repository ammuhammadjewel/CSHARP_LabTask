using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBoxName.Text;
            string pass = textBoxPass.Text;

            string name = "aaa";
            string passs = "bbb";

            if (uname == name && pass == passs)
            {
                MessageBox.Show("Login Sucessful");
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Uname or Pass error");
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
