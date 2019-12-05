using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AoaProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string source = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            string sqlSelectQuery = "select * from MyTable where Email='" + txtemail.Text + "'";
            SqlCommand comd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("User already exits");
            }
            else if (txtpass.Text != txtconfrmpass.Text)
            {
                MessageBox.Show("password not match");
            }
            else
            {
                string setting = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True";
                SqlConnection connection = new SqlConnection(setting);
                connection.Open();
                string query = "insert into MyTable(Username,Email,Password)values('" + txtusername.Text + "','" + txtemail.Text + "','" + txtpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Sign Up Successfully");
                connection.Close();
                this.Hide();

            }

        }

        private void linkforlogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
