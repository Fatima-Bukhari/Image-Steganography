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
    public partial class DecodeImg : Form
    {
        public DecodeImg()
        {
            InitializeComponent();
        }
        public static string SetValueForId;
        public DecodeImg(string str)
        {
            InitializeComponent();
            SetValueForId = str;
            txtUserid.Text = SetValueForId;


        }
        SqlConnection cn;
        SqlCommand cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DecodeImg_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True");
            cmd = new SqlCommand("select * from MyTable where UserID='" + SetValueForId + "'", cn);
            cn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //listBox1.Items.Add(dr["imgPath"].ToString());
                  txtPath.Text= dr["imgPath"].ToString();

                    /*byte[] piccarr = (byte[])dr["imgImage"];
                    MemoryStream  ms = new MemoryStream(piccarr);
                    ms.Seek(0, SeekOrigin.Begin);
                    pictureBox1.Image = Image.FromStream(ms);*/
                    Image image = Image.FromFile(txtPath.Text);
                    pictureBox1.Image = image;
                    Bitmap img = new Bitmap(txtPath.Text);
                        string message = "";
                        Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
                        int messagelength = lastpixel.B;
                        for (int i = 0; i < img.Width; i++)
                        {
                            for (int j = 0; j < img.Height; j++)
                            {
                                Color pixel = img.GetPixel(i, j);
                                if (i < 1 && j < messagelength)
                                {
                                    int value = pixel.B;
                                    char c = Convert.ToChar(value);
                                    string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                                    message = message + letter;

                                }
                            }
                        }
                        txtMsg.Text = message;

                    }
           

          }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
