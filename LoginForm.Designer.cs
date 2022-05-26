namespace Online_Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.winclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fast = new System.Windows.Forms.Label();
            this.forgpass = new System.Windows.Forms.Button();
            this.dataSet11 = new Online_Payment.DataSet1();
            this.logas = new System.Windows.Forms.ComboBox();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.Button();
            this.loginas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(283, 292);
            this.reg.Margin = new System.Windows.Forms.Padding(2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(89, 30);
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
            this.Pass.Location = new System.Drawing.Point(133, 165);
            this.Pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(92, 24);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Password";
            this.Pass.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // usersname
            // 
            this.usersname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usersname.Location = new System.Drawing.Point(261, 122);
            this.usersname.Margin = new System.Windows.Forms.Padding(2);
            this.usersname.Name = "usersname";
            this.usersname.Size = new System.Drawing.Size(138, 20);
            this.usersname.TabIndex = 4;
            this.usersname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username);
            this.usersname.MouseLeave += new System.EventHandler(this.username);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(261, 171);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(138, 20);
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
            this.usrname.Location = new System.Drawing.Point(133, 122);
            this.usrname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(105, 24);
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
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.winclose);
            this.header.Controls.Add(this.pictureBox1);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(532, 102);
            this.header.TabIndex = 6;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wise Payment";
            // 
            // winclose
            // 
            this.winclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.winclose.Image = ((System.Drawing.Image)(resources.GetObject("winclose.Image")));
            this.winclose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.winclose.Location = new System.Drawing.Point(508, 0);
            this.winclose.Margin = new System.Windows.Forms.Padding(2);
            this.winclose.Name = "winclose";
            this.winclose.Size = new System.Drawing.Size(23, 19);
            this.winclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winclose.TabIndex = 4;
            this.winclose.TabStop = false;
            this.winclose.Click += new System.EventHandler(this.Winclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(104, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fast
            // 
            this.fast.AutoSize = true;
            this.fast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fast.ForeColor = System.Drawing.Color.Red;
            this.fast.Location = new System.Drawing.Point(0, 353);
            this.fast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(85, 13);
            this.fast.TabIndex = 7;
            this.fast.Text = "Fast and Secure";
            // 
            // forgpass
            // 
            this.forgpass.Location = new System.Drawing.Point(136, 246);
            this.forgpass.Margin = new System.Windows.Forms.Padding(2);
            this.forgpass.Name = "forgpass";
            this.forgpass.Size = new System.Drawing.Size(116, 22);
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
            this.logas.Location = new System.Drawing.Point(261, 213);
            this.logas.Margin = new System.Windows.Forms.Padding(2);
            this.logas.Name = "logas";
            this.logas.Size = new System.Drawing.Size(138, 21);
            this.logas.TabIndex = 13;
            this.logas.Text = "Student";
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.Location = new System.Drawing.Point(424, 172);
            this.showpassword.Margin = new System.Windows.Forms.Padding(2);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(102, 17);
            this.showpassword.TabIndex = 15;
            this.showpassword.Text = "Show Password";
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.Showpassword_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(397, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(158, 292);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(64, 31);
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
            this.loginas.Location = new System.Drawing.Point(133, 213);
            this.loginas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginas.Name = "loginas";
            this.loginas.Size = new System.Drawing.Size(104, 24);
            this.loginas.TabIndex = 18;
            this.loginas.Text = "Login In As";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(397, 122);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loginform_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label2;
    }
}

