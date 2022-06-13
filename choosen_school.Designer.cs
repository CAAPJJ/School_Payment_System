namespace Online_Payment
{
    partial class choosen_school
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choosen_school));
            this.lbChoosenSchool = new System.Windows.Forms.Label();
            this.pnlliststudent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stulistgrview = new System.Windows.Forms.DataGridView();
            this.lblscool = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlliststudent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stulistgrview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChoosenSchool
            // 
            this.lbChoosenSchool.AutoSize = true;
            this.lbChoosenSchool.BackColor = System.Drawing.Color.Transparent;
            this.lbChoosenSchool.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoosenSchool.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbChoosenSchool.Location = new System.Drawing.Point(256, 81);
            this.lbChoosenSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChoosenSchool.Name = "lbChoosenSchool";
            this.lbChoosenSchool.Size = new System.Drawing.Size(147, 38);
            this.lbChoosenSchool.TabIndex = 74;
            this.lbChoosenSchool.Text = "Choosen";
            // 
            // pnlliststudent
            // 
            this.pnlliststudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlliststudent.Controls.Add(this.panel1);
            this.pnlliststudent.Controls.Add(this.lblscool);
            this.pnlliststudent.Controls.Add(this.lbChoosenSchool);
            this.pnlliststudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlliststudent.Location = new System.Drawing.Point(0, 0);
            this.pnlliststudent.Name = "pnlliststudent";
            this.pnlliststudent.Size = new System.Drawing.Size(888, 800);
            this.pnlliststudent.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stulistgrview);
            this.panel1.Location = new System.Drawing.Point(4, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 721);
            this.panel1.TabIndex = 80;
            // 
            // stulistgrview
            // 
            this.stulistgrview.AllowUserToAddRows = false;
            this.stulistgrview.AllowUserToDeleteRows = false;
            this.stulistgrview.AllowUserToResizeColumns = false;
            this.stulistgrview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            this.stulistgrview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stulistgrview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stulistgrview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.stulistgrview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stulistgrview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stulistgrview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stulistgrview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stulistgrview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stulistgrview.DefaultCellStyle = dataGridViewCellStyle4;
            this.stulistgrview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stulistgrview.Location = new System.Drawing.Point(0, 0);
            this.stulistgrview.Name = "stulistgrview";
            this.stulistgrview.ReadOnly = true;
            this.stulistgrview.RowHeadersVisible = false;
            this.stulistgrview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stulistgrview.RowTemplate.Height = 50;
            this.stulistgrview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stulistgrview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stulistgrview.Size = new System.Drawing.Size(888, 721);
            this.stulistgrview.TabIndex = 79;
            this.stulistgrview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stulistgrview_CellContentClick);
            this.stulistgrview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stulistgrview_CellDoubleClick);
            this.stulistgrview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stulistgrview_KeyDown);
            // 
            // lblscool
            // 
            this.lblscool.AutoSize = true;
            this.lblscool.BackColor = System.Drawing.Color.Transparent;
            this.lblscool.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscool.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscool.Location = new System.Drawing.Point(411, 81);
            this.lblscool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscool.Name = "lblscool";
            this.lblscool.Size = new System.Drawing.Size(132, 38);
            this.lblscool.TabIndex = 79;
            this.lblscool.Text = "Schools";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 426;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 70;
            // 
            // choosen_school
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(888, 800);
            this.Controls.Add(this.pnlliststudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choosen_school";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choosen_school";
            this.Load += new System.EventHandler(this.Choosen_school_Load);
            this.pnlliststudent.ResumeLayout(false);
            this.pnlliststudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stulistgrview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbChoosenSchool;
        private System.Windows.Forms.Panel pnlliststudent;
        private System.Windows.Forms.Label lblscool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView stulistgrview;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}