namespace Online_Payment
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelreg = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.email = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.laname = new System.Windows.Forms.Label();
            this.ages = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.TextBox();
            this.pusername = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.finame = new System.Windows.Forms.Label();
            this.chgpass = new System.Windows.Forms.Label();
            this.addschool = new System.Windows.Forms.DataGridView();
            this.lbladdschool = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addschool)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(268, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Profile";
            // 
            // cancelreg
            // 
            this.cancelreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cancelreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelreg.Font = new System.Drawing.Font("Cambria", 10F);
            this.cancelreg.Image = ((System.Drawing.Image)(resources.GetObject("cancelreg.Image")));
            this.cancelreg.Location = new System.Drawing.Point(211, 608);
            this.cancelreg.Name = "cancelreg";
            this.cancelreg.Size = new System.Drawing.Size(136, 50);
            this.cancelreg.TabIndex = 54;
            this.cancelreg.Text = "Edit";
            this.cancelreg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelreg.UseVisualStyleBackColor = false;
            this.cancelreg.Click += new System.EventHandler(this.Cancelreg_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Enabled = false;
            this.female.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.female.Location = new System.Drawing.Point(252, 244);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(85, 24);
            this.female.TabIndex = 53;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Enabled = false;
            this.male.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.male.Location = new System.Drawing.Point(162, 244);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(67, 24);
            this.male.TabIndex = 52;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(161, 426);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(206, 27);
            this.email.TabIndex = 51;
            // 
            // lname
            // 
            this.lname.Enabled = false;
            this.lname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lname.Location = new System.Drawing.Point(162, 197);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(206, 27);
            this.lname.TabIndex = 48;
            // 
            // laname
            // 
            this.laname.AutoSize = true;
            this.laname.Enabled = false;
            this.laname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.laname.ForeColor = System.Drawing.Color.Lime;
            this.laname.Location = new System.Drawing.Point(62, 200);
            this.laname.Name = "laname";
            this.laname.Size = new System.Drawing.Size(90, 20);
            this.laname.TabIndex = 47;
            this.laname.Text = "Last Name";
            this.laname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ages
            // 
            this.ages.Enabled = false;
            this.ages.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ages.Location = new System.Drawing.Point(162, 291);
            this.ages.Name = "ages";
            this.ages.Size = new System.Drawing.Size(206, 27);
            this.ages.TabIndex = 46;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Enabled = false;
            this.age.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.age.ForeColor = System.Drawing.Color.Lime;
            this.age.Location = new System.Drawing.Point(114, 298);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(38, 20);
            this.age.TabIndex = 45;
            this.age.Text = "Age";
            this.age.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Enabled = false;
            this.sex.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.sex.ForeColor = System.Drawing.Color.Lime;
            this.sex.Location = new System.Drawing.Point(116, 246);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(36, 20);
            this.sex.TabIndex = 44;
            this.sex.Text = "Sex";
            this.sex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Cambria", 10F);
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(61, 608);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(136, 50);
            this.save.TabIndex = 43;
            this.save.Text = "Save";
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(98, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // phonenum
            // 
            this.phonenum.Enabled = false;
            this.phonenum.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.phonenum.Location = new System.Drawing.Point(161, 479);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(211, 27);
            this.phonenum.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(16, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Phone Numnber";
            // 
            // usrname
            // 
            this.usrname.Enabled = false;
            this.usrname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.usrname.Location = new System.Drawing.Point(162, 356);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(206, 27);
            this.usrname.TabIndex = 37;
            // 
            // pusername
            // 
            this.pusername.AutoSize = true;
            this.pusername.Enabled = false;
            this.pusername.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.pusername.ForeColor = System.Drawing.Color.Lime;
            this.pusername.Location = new System.Drawing.Point(58, 363);
            this.pusername.Name = "pusername";
            this.pusername.Size = new System.Drawing.Size(94, 20);
            this.pusername.TabIndex = 36;
            this.pusername.Text = "User Name";
            this.pusername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fname
            // 
            this.fname.Enabled = false;
            this.fname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.fname.Location = new System.Drawing.Point(162, 136);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(206, 27);
            this.fname.TabIndex = 35;
            // 
            // finame
            // 
            this.finame.AutoSize = true;
            this.finame.Enabled = false;
            this.finame.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.finame.ForeColor = System.Drawing.Color.Lime;
            this.finame.Location = new System.Drawing.Point(62, 136);
            this.finame.Name = "finame";
            this.finame.Size = new System.Drawing.Size(94, 20);
            this.finame.TabIndex = 34;
            this.finame.Text = "First Name";
            this.finame.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chgpass
            // 
            this.chgpass.AutoSize = true;
            this.chgpass.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgpass.ForeColor = System.Drawing.Color.Lime;
            this.chgpass.Location = new System.Drawing.Point(209, 572);
            this.chgpass.Name = "chgpass";
            this.chgpass.Size = new System.Drawing.Size(163, 22);
            this.chgpass.TabIndex = 55;
            this.chgpass.Text = "Change Password";
            // 
            // addschool
            // 
            this.addschool.AllowUserToAddRows = false;
            this.addschool.AllowUserToDeleteRows = false;
            this.addschool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addschool.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.addschool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addschool.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.addschool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addschool.DefaultCellStyle = dataGridViewCellStyle4;
            this.addschool.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.addschool.Location = new System.Drawing.Point(423, 136);
            this.addschool.Name = "addschool";
            this.addschool.ReadOnly = true;
            this.addschool.RowHeadersVisible = false;
            this.addschool.RowTemplate.Height = 24;
            this.addschool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addschool.Size = new System.Drawing.Size(420, 522);
            this.addschool.TabIndex = 56;
            // 
            // lbladdschool
            // 
            this.lbladdschool.AutoSize = true;
            this.lbladdschool.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdschool.ForeColor = System.Drawing.Color.Red;
            this.lbladdschool.Location = new System.Drawing.Point(519, 82);
            this.lbladdschool.Name = "lbladdschool";
            this.lbladdschool.Size = new System.Drawing.Size(171, 51);
            this.lbladdschool.TabIndex = 57;
            this.lbladdschool.Text = "Schools";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.lbladdschool);
            this.Controls.Add(this.addschool);
            this.Controls.Add(this.chgpass);
            this.Controls.Add(this.cancelreg);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.laname);
            this.Controls.Add(this.ages);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.pusername);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.finame);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addschool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelreg;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label laname;
        private System.Windows.Forms.TextBox ages;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.Label pusername;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label finame;
        private System.Windows.Forms.Label chgpass;
        private System.Windows.Forms.DataGridView addschool;
        private System.Windows.Forms.Label lbladdschool;
    }
}