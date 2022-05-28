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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_School_Form));
            this.search = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.stuid = new System.Windows.Forms.TextBox();
            this.serch = new System.Windows.Forms.PictureBox();
            this.pnlP_School = new System.Windows.Forms.Panel();
            this.schlistgrview = new System.Windows.Forms.DataGridView();
            this.stugrv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclassfee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serch)).BeginInit();
            this.pnlP_School.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schlistgrview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stugrv)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.search.Location = new System.Drawing.Point(497, 118);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(351, 29);
            this.search.TabIndex = 3;
            this.search.Text = "Search Something";
            this.search.Click += new System.EventHandler(this.Search_Click);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(567, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "School Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // school_name
            // 
            this.school_name.Enabled = false;
            this.school_name.Location = new System.Drawing.Point(667, 497);
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
            this.button1.Location = new System.Drawing.Point(616, 614);
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
            this.label2.Location = new System.Drawing.Point(570, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "School Email";
            // 
            // schemail
            // 
            this.schemail.Enabled = false;
            this.schemail.Location = new System.Drawing.Point(667, 523);
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
            this.phone.Location = new System.Drawing.Point(558, 580);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(101, 17);
            this.phone.TabIndex = 16;
            this.phone.Text = "Phone number";
            // 
            // phonenum
            // 
            this.phonenum.Enabled = false;
            this.phonenum.Location = new System.Drawing.Point(667, 575);
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
            this.label5.Location = new System.Drawing.Point(552, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "School Address";
            // 
            // address
            // 
            this.address.Enabled = false;
            this.address.Location = new System.Drawing.Point(667, 549);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(209, 22);
            this.address.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(759, 614);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schoolclassfee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.schoolclassfee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schoolclassfee.DefaultCellStyle = dataGridViewCellStyle2;
            this.schoolclassfee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.schoolclassfee.Location = new System.Drawing.Point(228, 135);
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
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Your current school lsit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(585, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Student ID";
            // 
            // stuid
            // 
            this.stuid.Location = new System.Drawing.Point(667, 471);
            this.stuid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuid.Name = "stuid";
            this.stuid.Size = new System.Drawing.Size(209, 22);
            this.stuid.TabIndex = 63;
            this.stuid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stuid_KeyDown);
            // 
            // serch
            // 
            this.serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serch.Image = ((System.Drawing.Image)(resources.GetObject("serch.Image")));
            this.serch.Location = new System.Drawing.Point(849, 118);
            this.serch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serch.Name = "serch";
            this.serch.Size = new System.Drawing.Size(35, 28);
            this.serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serch.TabIndex = 4;
            this.serch.TabStop = false;
            this.serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // pnlP_School
            // 
            this.pnlP_School.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlP_School.Controls.Add(this.schoolclassfee);
            this.pnlP_School.Controls.Add(this.label4);
            this.pnlP_School.Controls.Add(this.label7);
            this.pnlP_School.Controls.Add(this.button2);
            this.pnlP_School.Controls.Add(this.stuid);
            this.pnlP_School.Controls.Add(this.search);
            this.pnlP_School.Controls.Add(this.label5);
            this.pnlP_School.Controls.Add(this.serch);
            this.pnlP_School.Controls.Add(this.phone);
            this.pnlP_School.Controls.Add(this.stugrv);
            this.pnlP_School.Controls.Add(this.label2);
            this.pnlP_School.Controls.Add(this.school_name);
            this.pnlP_School.Controls.Add(this.button1);
            this.pnlP_School.Controls.Add(this.address);
            this.pnlP_School.Controls.Add(this.label3);
            this.pnlP_School.Controls.Add(this.schemail);
            this.pnlP_School.Controls.Add(this.phonenum);
            this.pnlP_School.Controls.Add(this.schlistgrview);
            this.pnlP_School.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP_School.Location = new System.Drawing.Point(0, 0);
            this.pnlP_School.Name = "pnlP_School";
            this.pnlP_School.Size = new System.Drawing.Size(888, 700);
            this.pnlP_School.TabIndex = 67;
            this.pnlP_School.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlP_School_Paint);
            // 
            // schlistgrview
            // 
            this.schlistgrview.AllowUserToAddRows = false;
            this.schlistgrview.AllowUserToDeleteRows = false;
            this.schlistgrview.AllowUserToResizeColumns = false;
            this.schlistgrview.AllowUserToResizeRows = false;
            this.schlistgrview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schlistgrview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schlistgrview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schlistgrview.Location = new System.Drawing.Point(12, 150);
            this.schlistgrview.Name = "schlistgrview";
            this.schlistgrview.ReadOnly = true;
            this.schlistgrview.RowHeadersVisible = false;
            this.schlistgrview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.schlistgrview.RowTemplate.Height = 24;
            this.schlistgrview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.schlistgrview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schlistgrview.Size = new System.Drawing.Size(479, 538);
            this.schlistgrview.TabIndex = 0;
            this.schlistgrview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schlistgrview_CellClick);
            this.schlistgrview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schlistgrview_CellDoubleClick);
            // 
            // stugrv
            // 
            this.stugrv.AllowUserToAddRows = false;
            this.stugrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stugrv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.stugrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stugrv.Location = new System.Drawing.Point(497, 150);
            this.stugrv.Margin = new System.Windows.Forms.Padding(4);
            this.stugrv.Name = "stugrv";
            this.stugrv.ReadOnly = true;
            this.stugrv.RowHeadersVisible = false;
            this.stugrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stugrv.Size = new System.Drawing.Size(387, 315);
            this.stugrv.TabIndex = 7;
            this.stugrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stugrv_CellClick);
            // 
            // P_School_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.pnlP_School);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "P_School_Form";
            this.Text = "P_School_Form";
            this.Load += new System.EventHandler(this.P_School_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolclassfee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serch)).EndInit();
            this.pnlP_School.ResumeLayout(false);
            this.pnlP_School.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schlistgrview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stugrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox serch;
        private System.Windows.Forms.TextBox search;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stuid;
        private System.Windows.Forms.Panel pnlP_School;
        private System.Windows.Forms.DataGridView schlistgrview;
        private System.Windows.Forms.DataGridView stugrv;
    }
}