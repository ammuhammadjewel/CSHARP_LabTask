using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login aa = new Login(); 
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string uname = textBoxUname.Text;
            string pass = textBoxPass.Text;
            string email = textBoxEmail.Text;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"");
                conn.Open();

                string query = "insert into Userinfo (Fname, Lname, Uname, Password, Email) VALUES (' " +fname + " ' , ' "+lname+"' , ' "+uname+" ', '"+pass+"', '"+email+" ')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Registration complete!");
                conn.Close();
            }
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}