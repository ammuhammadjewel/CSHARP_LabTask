using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Data.SqlConnection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace CRUD_Database
{
    public partial class Form1 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6P5IDMM\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            //conn.Open();
            SqlConnection con = new SqlConnection(cs);

            string query2 = "select * from Employee where Id = @id";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@id", idtb.Text);
            con.Open();
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show(idtb.Text + " ID already Exists !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else
            {
                /*
                 if (dr.HasRows == true)
                {
                    MessageBox.Show(idtb.Text + " ID already Exists !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    con.Close();

                    string query = "insert into Employee values(@id,@name,@gender,@desig,@salary)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idtb.Text);
                    cmd.Parameters.AddWithValue("@name", nametb.Text);
                    cmd.Parameters.AddWithValue("@contact", contacttb.Text);
                    cmd.Parameters.AddWithValue("@age", ageud.Value);
                    cmd.Parameters.AddWithValue("@address", addresstb.Text);
                    cmd.Parameters.AddWithValue("@gender", gendercb.SelectedItem);
                    cmd.Parameters.AddWithValue("@testno", testnotb.Text);
                    cmd.Parameters.AddWithValue("@condition", conditioncb.SelectedItem);
                    cmd.Parameters.AddWithValue("@teststatus", teststatuscb.SelectedItem);


                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Inserted SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 */

                con.Close();

                string query = "insert into Employee values(@id,@name,@gender,@desig,@salary)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idtb.Text);
                cmd.Parameters.AddWithValue("@name", nametb.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@desig", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@salary", salarytb.Text);


                con.Open();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Inserted SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                }
                else
                {
                    MessageBox.Show("Insertion Failed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                ResetControls();
            }
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection();
            string query = "Select * from Employee ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            //agetb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            salarytb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string query = "update Employee set Id = @id, name = @name, gender= @gender, age= @age, desigantion = @desig, salary = @salary where Id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", idtb.Text);
            cmd.Parameters.AddWithValue("@name", nametb.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@desig", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", salarytb.Text);


            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
            }
            else
            {
                MessageBox.Show("Updation Failed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            ResetControls();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string query = "delete from Employee where Id = @id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", idtb.Text);
            cmd.Parameters.AddWithValue("@name", nametb.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@desig", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", salarytb.Text);


            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
            }
            else
            {
                MessageBox.Show("Deletion Failed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            ResetControls();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        void ResetControls()
        {
            idtb.Clear();
            nametb.Clear();
            comboBox1.SelectedItem = null;
            numericUpDown1.Value = 0;
            comboBox2.SelectedItem = null;
            salarytb.Clear();

            idtb.Focus();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string query = "select * from Employee where name like @name + '%";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", Searchtb.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            if(data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No data found! ");
                dataGridView1.DataSource = null;
            }
        }

        private void Searchtb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string query = "select * from Employee where naem like @name + '%";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", Searchtb.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No data found! ");
                dataGridView1.DataSource = null;
            }
        }
    }
}
