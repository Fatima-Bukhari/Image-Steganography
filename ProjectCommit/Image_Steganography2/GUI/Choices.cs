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
    public partial class Choices : Form
    {
        public Choices()
        {
            InitializeComponent();
        }
        public static string SetValueForId;
        public Choices(string str)
        {
            InitializeComponent();
            SetValueForId = str;
            txtUserid.Text = SetValueForId;


        }
        private void Choices_Load(object sender, EventArgs e)
        {

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            EncodeForm ef = new EncodeForm(SetValueForId);
            ef.Show();
            this.Hide();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm(SetValueForId);
            kf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
