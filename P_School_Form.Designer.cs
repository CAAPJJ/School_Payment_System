namespace Online_Payment
{
    partial class P_School_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_School_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new System.Windows.Forms.TextBox();
            this.serch = new System.Windows.Forms.PictureBox();
            this.stugrv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.school_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.schemail = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.schoolclassfee = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbSchoolName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.stuid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stugrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclassfee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.search.Location = new System.Drawing.Point(498, 90);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(351, 29);
            this.search.TabIndex = 3;
            this.search.Text = "Search Something";
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // serch
            // 
            this.serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serch.Image = ((System.Drawing.Image)(resources.GetObject("serch.Image")));
            this.serch.Location = new System.Drawing.Point(850, 90);
            this.serch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serch.Name = "serch";
            this.serch.Size = new System.Drawing.Size(35, 28);
            this.serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serch.TabIndex = 4;
            this.serch.TabStop = false;
            this.serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // stugrv
            // 
            this.stugrv.AllowUserToAddRows = false;
            this.stugrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stugrv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.stugrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stugrv.Location = new System.Drawing.Point(498, 125);
            this.stugrv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stugrv.Name = "stugrv";
            this.stugrv.ReadOnly = true;
            this.stugrv.RowHeadersVisible = false;
            this.stugrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stugrv.Size = new System.Drawing.Size(387, 315);
            this.stugrv.TabIndex = 7;
            this.stugrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stugrv_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(541, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "School Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // school_name
            // 
            this.school_name.Enabled = false;
            this.school_name.Location = new System.Drawing.Point(640, 485);
            this.school_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.school_name.Name = "school_name";
            this.school_name.Size = new System.Drawing.Size(209, 22);
            this.school_name.TabIndex = 10;
            this.school_name.TextChanged += new System.EventHandler(this.School_name_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(597, 655);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add School";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(541, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "School Email";
            // 
            // schemail
            // 
            this.schemail.Enabled = false;
            this.schemail.Location = new System.Drawing.Point(640, 528);
            this.schemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schemail.Name = "schemail";
            this.schemail.Size = new System.Drawing.Size(209, 22);
            this.schemail.TabIndex = 13;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Enabled = false;
            this.phone.ForeColor = System.Drawing.Color.Red;
            this.phone.Location = new System.Drawing.Point(531, 619);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(101, 17);
            this.phone.TabIndex = 16;
            this.phone.Text = "Phone number";
            // 
            // phonenum
            // 
            this.phonenum.Enabled = false;
            this.phonenum.Location = new System.Drawing.Point(640, 614);
            this.phonenum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(209, 22);
            this.phonenum.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(517, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "School Address";
            // 
            // address
            // 
            this.address.Enabled = false;
            this.address.Location = new System.Drawing.Point(640, 571);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(209, 22);
            this.address.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(732, 655);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // schoolclassfee
            // 
            this.schoolclassfee.AllowUserToAddRows = false;
            this.schoolclassfee.AllowUserToDeleteRows = false;
            this.schoolclassfee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schoolclassfee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.schoolclassfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schoolclassfee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.schoolclassfee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schoolclassfee.DefaultCellStyle = dataGridViewCellStyle4;
            this.schoolclassfee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.schoolclassfee.Location = new System.Drawing.Point(793, 11);
            this.schoolclassfee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schoolclassfee.Name = "schoolclassfee";
            this.schoolclassfee.ReadOnly = true;
            this.schoolclassfee.RowHeadersVisible = false;
            this.schoolclassfee.RowTemplate.Height = 24;
            this.schoolclassfee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schoolclassfee.Size = new System.Drawing.Size(56, 10);
            this.schoolclassfee.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(44, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Your current school lsit";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 91);
            this.button3.TabIndex = 59;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbSchoolName
            // 
            this.lbSchoolName.AutoSize = true;
            this.lbSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchoolName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSchoolName.Location = new System.Drawing.Point(21, 56);
            this.lbSchoolName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSchoolName.Name = "lbSchoolName";
            this.lbSchoolName.Size = new System.Drawing.Size(195, 29);
            this.lbSchoolName.TabIndex = 60;
            this.lbSchoolName.Text = "st mary university";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(263, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 29);
            this.label6.TabIndex = 61;
            this.label6.Text = "number of student 3";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 540);
            this.panel1.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(537, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Student ID";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(640, 446);
            this.stuid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(209, 22);
            this.stuid.TabIndex = 63;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 315);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 91);
            this.button4.TabIndex = 60;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 216);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(252, 91);
            this.button5.TabIndex = 61;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 117);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(252, 91);
            this.button6.TabIndex = 62;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 414);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(252, 91);
            this.button8.TabIndex = 65;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 514);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(252, 91);
            this.button7.TabIndex = 66;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // P_School_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stuid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSchoolName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.schoolclassfee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schemail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.school_name);
            this.Controls.Add(this.stugrv);
            this.Controls.Add(this.serch);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "P_School_Form";
            this.Text = "P_School_Form";
            this.Load += new System.EventHandler(this.P_School_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stugrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclassfee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox serch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView stugrv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox school_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox schemail;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView schoolclassfee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbSchoolName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stuid;
    }
}