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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string userid;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkforsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string source = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            string sqlSelectQuery = "select * from MyTable where Email='" + txtloginEmail.Text + "'and Password='" + txtloginPass.Text + "' ";
            SqlCommand comd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = comd.ExecuteReader();
            if (dr.Read())
            {
                userid = (dr["UserID"].ToString());
                MessageBox.Show(userid, "User login successfully");
                Choices c = new Choices(userid);
                c.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
