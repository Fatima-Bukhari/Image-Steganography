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
    public partial class EncodeForm : Form
    {
        public EncodeForm()
        {
            InitializeComponent();
        }
        public static string SetValueForId;
        public EncodeForm(string SetValueForId)
        {
            InitializeComponent();
            txtUserid.Text = SetValueForId;
            Fillcombobox();
        }
        void Fillcombobox()
        {
            string setting = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True";
            SqlConnection connection = new SqlConnection(setting);
            string query = "Select * FROM MyTable";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader sdr;
            try
            {
                connection.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string id = sdr.GetValue(0).ToString();
                    cmb_useridz.Items.Add(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
      
        private void EncodeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (* .png, * .jpg) | * .png; * .jpg";
            openDialog.InitialDirectory = @"C:\\Users\\Shiza\\Pictures";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            /* string setting = "Data Source=HAIER-PC;Initial Catalog=AoaProject;Integrated Security=True";
             SqlConnection connection = new SqlConnection(setting);
             string query = "update MyTable set MessageKey='" + this.txtKey.Text + "'and imgPath='@imgpath' and imgImage='@imgimage' where Id='" + this.cmb_useridz.SelectedItem + "';";
             connection.Open();
             SqlCommand cmd = new SqlCommand(query, connection);
             if (cmd.ExecuteNonQuery() == 1)
             {
                 MessageBox.Show("Updated");
             }
             else
             {
                 MessageBox.Show("Not Updated");
             }
             */
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < textBoxMessage.TextLength)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(textBoxMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine(" letter : " + letter + " value : " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));

                    }
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxMessage.TextLength));
                    }
                }
            }
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Image Files (* .png, * .jpg) | * .png; * .jpg";
            savefile.InitialDirectory = @"C:\\Users\\Shiza\\Pictures";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = savefile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
                img.Save(textBoxFilePath.Text);


                SqlConnection cn = new SqlConnection(@"Data Source=localhost\\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True");
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] pic_arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic_arr, 0, pic_arr.Length);
                string setting = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ImageSteganography;Integrated Security=True";
                SqlConnection connection = new SqlConnection(setting);
                string query = "update MyTable set  imgPath='" + textBoxFilePath.Text + "', imgImage='"+ pic_arr + "',MessageKey='"+ txtKey.Text + "' where UserID='" + cmb_useridz.Text + "' ";

                
                SqlCommand cmd = new SqlCommand(query, connection);
           
             
                connection.Open();
                try
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Send successfully");
                        Choices choices = new Choices();
                        choices.Show();
                        this.Hide();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
