﻿namespace Online_Payment
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.reg = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.Label();
            this.usersname = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usrname = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerlabel = new System.Windows.Forms.Label();
            this.fast = new System.Windows.Forms.Label();
            this.forgpass = new System.Windows.Forms.Button();
            this.dataSet11 = new Online_Payment.DataSet1();
            this.logas = new System.Windows.Forms.ComboBox();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.Button();
            this.loginas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.winclose = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winclose)).BeginInit();
            this.SuspendLayout();
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(377, 360);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(119, 37);
            this.reg.TabIndex = 1;
            this.reg.Text = "Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Red;
            this.Pass.Location = new System.Drawing.Point(177, 203);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(120, 29);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Password";
            this.Pass.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // usersname
            // 
            this.usersname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usersname.Location = new System.Drawing.Point(348, 150);
            this.usersname.Name = "usersname";
            this.usersname.Size = new System.Drawing.Size(183, 22);
            this.usersname.TabIndex = 4;
            this.usersname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username);
            this.usersname.MouseLeave += new System.EventHandler(this.username);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(348, 210);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(183, 22);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.MouseCaptureChanged += new System.EventHandler(this.username);
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.BackColor = System.Drawing.Color.AliceBlue;
            this.usrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname.ForeColor = System.Drawing.Color.Red;
            this.usrname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrname.Location = new System.Drawing.Point(177, 150);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(135, 29);
            this.usrname.TabIndex = 2;
            this.usrname.Text = "User Name";
            this.usrname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usrname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.Red;
            this.header.Controls.Add(this.winclose);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.headerlabel);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(709, 125);
            this.header.TabIndex = 6;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(139, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 119);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.Location = new System.Drawing.Point(276, 36);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(244, 33);
            this.headerlabel.TabIndex = 0;
            this.headerlabel.Text = "Jase Online Paymet";
            // 
            // fast
            // 
            this.fast.AutoSize = true;
            this.fast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fast.ForeColor = System.Drawing.Color.Red;
            this.fast.Location = new System.Drawing.Point(0, 433);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(112, 17);
            this.fast.TabIndex = 7;
            this.fast.Text = "Fast and Secure";
            // 
            // forgpass
            // 
            this.forgpass.Location = new System.Drawing.Point(182, 303);
            this.forgpass.Name = "forgpass";
            this.forgpass.Size = new System.Drawing.Size(155, 27);
            this.forgpass.TabIndex = 11;
            this.forgpass.Text = "Forget Passowrd?";
            this.forgpass.UseVisualStyleBackColor = true;
            this.forgpass.Visible = false;
            this.forgpass.Click += new System.EventHandler(this.Forgpass_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logas
            // 
            this.logas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logas.FormattingEnabled = true;
            this.logas.Items.AddRange(new object[] {
            "School Adminstrator",
            "Student",
            "Parent"});
            this.logas.Location = new System.Drawing.Point(348, 262);
            this.logas.Name = "logas";
            this.logas.Size = new System.Drawing.Size(183, 24);
            this.logas.TabIndex = 13;
            this.logas.Text = "Student";
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.Location = new System.Drawing.Point(566, 212);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(129, 21);
            this.showpassword.TabIndex = 15;
            this.showpassword.Text = "Show Password";
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.Showpassword_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(529, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(211, 360);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(86, 38);
            this.log.TabIndex = 0;
            this.log.Text = "Log In";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // loginas
            // 
            this.loginas.AutoSize = true;
            this.loginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginas.ForeColor = System.Drawing.Color.Red;
            this.loginas.Location = new System.Drawing.Point(177, 262);
            this.loginas.Name = "loginas";
            this.loginas.Size = new System.Drawing.Size(131, 29);
            this.loginas.TabIndex = 18;
            this.loginas.Text = "Login In As";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(529, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // winclose
            // 
            this.winclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.winclose.Image = ((System.Drawing.Image)(resources.GetObject("winclose.Image")));
            this.winclose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.winclose.Location = new System.Drawing.Point(678, 0);
            this.winclose.Name = "winclose";
            this.winclose.Size = new System.Drawing.Size(31, 23);
            this.winclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winclose.TabIndex = 4;
            this.winclose.TabStop = false;
            this.winclose.Click += new System.EventHandler(this.Winclose_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.loginas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.logas);
            this.Controls.Add(this.forgpass);
            this.Controls.Add(this.fast);
            this.Controls.Add(this.header);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usersname);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loginform_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox usersname;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.Label fast;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button forgpass;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ComboBox logas;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loginas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox winclose;
    }
}
