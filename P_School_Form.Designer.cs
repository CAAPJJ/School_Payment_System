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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new System.Windows.Forms.TextBox();
            this.serch = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblclassfee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stugrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclassfee)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.search.Location = new System.Drawing.Point(89, 90);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(350, 28);
            this.search.TabIndex = 3;
            this.search.Text = "Search Something";
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // serch
            // 
            this.serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serch.Image = ((System.Drawing.Image)(resources.GetObject("serch.Image")));
            this.serch.Location = new System.Drawing.Point(441, 90);
            this.serch.Name = "serch";
            this.serch.Size = new System.Drawing.Size(35, 28);
            this.serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serch.TabIndex = 4;
            this.serch.TabStop = false;
            this.serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "school";
            // 
            // stugrv
            // 
            this.stugrv.AllowUserToAddRows = false;
            this.stugrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stugrv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.stugrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stugrv.Location = new System.Drawing.Point(27, 125);
            this.stugrv.Margin = new System.Windows.Forms.Padding(4);
            this.stugrv.Name = "stugrv";
            this.stugrv.ReadOnly = true;
            this.stugrv.RowHeadersVisible = false;
            this.stugrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stugrv.Size = new System.Drawing.Size(483, 562);
            this.stugrv.TabIndex = 7;
            this.stugrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stugrv_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(542, 490);
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
            this.label2.Location = new System.Drawing.Point(542, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "School Email";
            // 
            // schemail
            // 
            this.schemail.Enabled = false;
            this.schemail.Location = new System.Drawing.Point(640, 528);
            this.schemail.Name = "schemail";
            this.schemail.Size = new System.Drawing.Size(209, 22);
            this.schemail.TabIndex = 13;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Enabled = false;
            this.phone.ForeColor = System.Drawing.Color.Red;
            this.phone.Location = new System.Drawing.Point(530, 619);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(101, 17);
            this.phone.TabIndex = 16;
            this.phone.Text = "Phone number";
            // 
            // phonenum
            // 
            this.phonenum.Enabled = false;
            this.phonenum.Location = new System.Drawing.Point(640, 614);
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
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(209, 22);
            this.address.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(732, 655);
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
            this.schoolclassfee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.schoolclassfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schoolclassfee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.schoolclassfee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.schoolclassfee.DefaultCellStyle = dataGridViewCellStyle6;
            this.schoolclassfee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.schoolclassfee.Location = new System.Drawing.Point(520, 125);
            this.schoolclassfee.Name = "schoolclassfee";
            this.schoolclassfee.ReadOnly = true;
            this.schoolclassfee.RowHeadersVisible = false;
            this.schoolclassfee.RowTemplate.Height = 24;
            this.schoolclassfee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.schoolclassfee.Size = new System.Drawing.Size(356, 354);
            this.schoolclassfee.TabIndex = 57;
            // 
            // lblclassfee
            // 
            this.lblclassfee.AutoSize = true;
            this.lblclassfee.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclassfee.ForeColor = System.Drawing.Color.Red;
            this.lblclassfee.Location = new System.Drawing.Point(557, 89);
            this.lblclassfee.Name = "lblclassfee";
            this.lblclassfee.Size = new System.Drawing.Size(220, 22);
            this.lblclassfee.TabIndex = 58;
            this.lblclassfee.Text = "School Fee Infroramtion";
            // 
            // P_School_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.lblclassfee);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serch);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_School_Form";
            this.Text = "P_School_Form";
            this.Load += new System.EventHandler(this.P_School_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stugrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolclassfee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox serch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label lblclassfee;
    }
}