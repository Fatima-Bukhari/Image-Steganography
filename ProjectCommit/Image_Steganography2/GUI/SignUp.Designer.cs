namespace AoaProject
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.linkforlogin = new System.Windows.Forms.LinkLabel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblCnfrmpass = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtconfrmpass = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkforlogin
            // 
            this.linkforlogin.AutoSize = true;
            this.linkforlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.linkforlogin.Location = new System.Drawing.Point(447, 397);
            this.linkforlogin.Name = "linkforlogin";
            this.linkforlogin.Size = new System.Drawing.Size(160, 19);
            this.linkforlogin.TabIndex = 28;
            this.linkforlogin.TabStop = true;
            this.linkforlogin.Text = "Click here for Log in";
            this.linkforlogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkforlogin_LinkClicked);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignup.Location = new System.Drawing.Point(437, 346);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(181, 48);
            this.btnSignup.TabIndex = 27;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblCnfrmpass
            // 
            this.lblCnfrmpass.AutoSize = true;
            this.lblCnfrmpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.lblCnfrmpass.Location = new System.Drawing.Point(273, 295);
            this.lblCnfrmpass.Name = "lblCnfrmpass";
            this.lblCnfrmpass.Size = new System.Drawing.Size(145, 19);
            this.lblCnfrmpass.TabIndex = 26;
            this.lblCnfrmpass.Text = "Confirm Password";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.lblpass.Location = new System.Drawing.Point(273, 239);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(80, 19);
            this.lblpass.TabIndex = 25;
            this.lblpass.Text = "Password";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.lblemail.Location = new System.Drawing.Point(273, 183);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 19);
            this.lblemail.TabIndex = 24;
            this.lblemail.Text = "Email";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.lblusername.Location = new System.Drawing.Point(273, 126);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(87, 19);
            this.lblusername.TabIndex = 23;
            this.lblusername.Text = "Username";
            // 
            // txtconfrmpass
            // 
            this.txtconfrmpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfrmpass.Location = new System.Drawing.Point(437, 289);
            this.txtconfrmpass.Name = "txtconfrmpass";
            this.txtconfrmpass.Size = new System.Drawing.Size(241, 27);
            this.txtconfrmpass.TabIndex = 22;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(437, 233);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(241, 27);
            this.txtpass.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(437, 177);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(241, 27);
            this.txtemail.TabIndex = 20;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(437, 120);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(241, 27);
            this.txtusername.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 28);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 86);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 100);
            this.panel3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(305, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Image Steganographer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(218)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(913, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(951, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkforlogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblCnfrmpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtconfrmpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkforlogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblCnfrmpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtconfrmpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}