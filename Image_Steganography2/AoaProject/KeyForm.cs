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
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();
        }
        public static string SetValueForId;
        public KeyForm(string str)
        {
            InitializeComponent();
            SetValueForId = str;
            txtUserid.Text = SetValueForId;


        }
        SqlConnection cn;
        SqlCommand cmd;

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True");
            cmd = new SqlCommand("select * from MyTable where UserID='" + SetValueForId + "'", cn);
            cn.Open();
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string key = dr["MessageKey"].ToString();

                if (key == txtboxkey.Text)
                {
                    MessageBox.Show("Entered key is correct");
                    DecodeImg df = new DecodeImg(SetValueForId);
                    df.Show();
                }
                else
                {
                    MessageBox.Show("You entered wrong key");
                }

                this.Hide();




            }
        }

        private void KeyForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxkey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
