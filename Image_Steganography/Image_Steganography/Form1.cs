using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png,*.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\Fatima Bukhari\Desktop";

            if(openDialog.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBox1.Text);
            for(int i=0;i<img.Width;i++)
            {
                for(int j=0;j<img.Height;j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if(i<1 && j<textBox2.TextLength)
                    {
                        Console.WriteLine("R = [ " + i + "][ " + j + "]= " + pixel.R);
                        Console.WriteLine("G = [ " + i + "][ " + j + "]= " + pixel.G);
                        Console.WriteLine("B = [ " + i + "][ " + j + "]= " + pixel.B);

                        char letter = Convert.ToChar(textBox2.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("Letter : " + letter + " Value : " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, pixel.B, value));
                    }
                }
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png,*.jpg) | *.png; *.jpg";
            saveFile.InitialDirectory = @"C:\Users\Fatima Bukhari\Desktop";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = textBox1.Text;
                img.Save(textBox1.Text);
            }
        }
    }
}
