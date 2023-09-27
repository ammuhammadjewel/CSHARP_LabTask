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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button2Registration_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
