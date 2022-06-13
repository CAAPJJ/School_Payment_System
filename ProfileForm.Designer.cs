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
            this.label1 = new System.Windows.Forms.Label();
            this.editprofile = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(215, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Profile";
            // 
            // editprofile
            // 
            this.editprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editprofile.Font = new System.Drawing.Font("Cambria", 10F);
            this.editprofile.Image = ((System.Drawing.Image)(resources.GetObject("editprofile.Image")));
            this.editprofile.Location = new System.Drawing.Point(436, 478);
            this.editprofile.Margin = new System.Windows.Forms.Padding(2);
            this.editprofile.Name = "editprofile";
            this.editprofile.Size = new System.Drawing.Size(102, 41);
            this.editprofile.TabIndex = 54;
            this.editprofile.Text = "Edit";
            this.editprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editprofile.UseVisualStyleBackColor = false;
            this.editprofile.Click += new System.EventHandler(this.editprofile_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Enabled = false;
            this.female.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.female.Location = new System.Drawing.Point(321, 201);
            this.female.Margin = new System.Windows.Forms.Padding(2);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(70, 20);
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
            this.male.Location = new System.Drawing.Point(254, 201);
            this.male.Margin = new System.Windows.Forms.Padding(2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(56, 20);
            this.male.TabIndex = 52;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(253, 349);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(156, 23);
            this.email.TabIndex = 51;
            // 
            // lname
            // 
            this.lname.Enabled = false;
            this.lname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lname.Location = new System.Drawing.Point(254, 163);
            this.lname.Margin = new System.Windows.Forms.Padding(2);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(155, 23);
            this.lname.TabIndex = 48;
            // 
            // laname
            // 
            this.laname.AutoSize = true;
            this.laname.Enabled = false;
            this.laname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.laname.ForeColor = System.Drawing.Color.Lime;
            this.laname.Location = new System.Drawing.Point(178, 165);
            this.laname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laname.Name = "laname";
            this.laname.Size = new System.Drawing.Size(73, 16);
            this.laname.TabIndex = 47;
            this.laname.Text = "Last Name";
            this.laname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ages
            // 
            this.ages.Enabled = false;
            this.ages.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ages.Location = new System.Drawing.Point(254, 239);
            this.ages.Margin = new System.Windows.Forms.Padding(2);
            this.ages.Name = "ages";
            this.ages.Size = new System.Drawing.Size(156, 23);
            this.ages.TabIndex = 46;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Enabled = false;
            this.age.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.age.ForeColor = System.Drawing.Color.Lime;
            this.age.Location = new System.Drawing.Point(218, 245);
            this.age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(31, 16);
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
            this.sex.Location = new System.Drawing.Point(219, 203);
            this.sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(29, 16);
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
            this.save.Location = new System.Drawing.Point(123, 478);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 41);
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
            this.label4.Location = new System.Drawing.Point(206, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // phonenum
            // 
            this.phonenum.Enabled = false;
            this.phonenum.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.phonenum.Location = new System.Drawing.Point(253, 392);
            this.phonenum.Margin = new System.Windows.Forms.Padding(2);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(159, 23);
            this.phonenum.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(144, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Phone Numnber";
            // 
            // usrname
            // 
            this.usrname.Enabled = false;
            this.usrname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.usrname.Location = new System.Drawing.Point(254, 292);
            this.usrname.Margin = new System.Windows.Forms.Padding(2);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(156, 23);
            this.usrname.TabIndex = 37;
            // 
            // pusername
            // 
            this.pusername.AutoSize = true;
            this.pusername.Enabled = false;
            this.pusername.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.pusername.ForeColor = System.Drawing.Color.Lime;
            this.pusername.Location = new System.Drawing.Point(176, 298);
            this.pusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pusername.Name = "pusername";
            this.pusername.Size = new System.Drawing.Size(75, 16);
            this.pusername.TabIndex = 36;
            this.pusername.Text = "User Name";
            this.pusername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fname
            // 
            this.fname.Enabled = false;
            this.fname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.fname.Location = new System.Drawing.Point(254, 113);
            this.fname.Margin = new System.Windows.Forms.Padding(2);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(156, 23);
            this.fname.TabIndex = 35;
            // 
            // finame
            // 
            this.finame.AutoSize = true;
            this.finame.Enabled = false;
            this.finame.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.finame.ForeColor = System.Drawing.Color.Lime;
            this.finame.Location = new System.Drawing.Point(178, 113);
            this.finame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.finame.Name = "finame";
            this.finame.Size = new System.Drawing.Size(76, 16);
            this.finame.TabIndex = 34;
            this.finame.Text = "First Name";
            this.finame.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chgpass
            // 
            this.chgpass.AutoSize = true;
            this.chgpass.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgpass.ForeColor = System.Drawing.Color.Lime;
            this.chgpass.Location = new System.Drawing.Point(250, 449);
            this.chgpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chgpass.Name = "chgpass";
            this.chgpass.Size = new System.Drawing.Size(130, 17);
            this.chgpass.TabIndex = 55;
            this.chgpass.Text = "Change Password";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(666, 569);
            this.Controls.Add(this.chgpass);
            this.Controls.Add(this.editprofile);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfileForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editprofile;
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
    }
}