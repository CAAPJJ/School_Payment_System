namespace FormMainMenu
{
    partial class MainMenu
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.setting = new FontAwesome.Sharp.IconButton();
            this.customer = new FontAwesome.Sharp.IconButton();
            this.porduct = new FontAwesome.Sharp.IconButton();
            this.order = new FontAwesome.Sharp.IconButton();
            this.dash = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelmenu.Controls.Add(this.setting);
            this.panelmenu.Controls.Add(this.customer);
            this.panelmenu.Controls.Add(this.porduct);
            this.panelmenu.Controls.Add(this.order);
            this.panelmenu.Controls.Add(this.dash);
            this.panelmenu.Controls.Add(this.panelLogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 576);
            this.panelmenu.TabIndex = 0;
            // 
            // setting
            // 
            this.setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.setting.IconColor = System.Drawing.Color.Gainsboro;
            this.setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.setting.IconSize = 32;
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.Location = new System.Drawing.Point(0, 380);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.setting.Size = new System.Drawing.Size(220, 60);
            this.setting.TabIndex = 5;
            this.setting.Text = "Setting";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // customer
            // 
            this.customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.customer.IconColor = System.Drawing.Color.Gainsboro;
            this.customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customer.IconSize = 32;
            this.customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer.Location = new System.Drawing.Point(0, 320);
            this.customer.Name = "customer";
            this.customer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.customer.Size = new System.Drawing.Size(220, 60);
            this.customer.TabIndex = 4;
            this.customer.Text = "Customers";
            this.customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // porduct
            // 
            this.porduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.porduct.FlatAppearance.BorderSize = 0;
            this.porduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.porduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.porduct.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.porduct.IconColor = System.Drawing.Color.Gainsboro;
            this.porduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.porduct.IconSize = 32;
            this.porduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.porduct.Location = new System.Drawing.Point(0, 260);
            this.porduct.Name = "porduct";
            this.porduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.porduct.Size = new System.Drawing.Size(220, 60);
            this.porduct.TabIndex = 3;
            this.porduct.Text = "Products";
            this.porduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.porduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.porduct.UseVisualStyleBackColor = true;
            this.porduct.Click += new System.EventHandler(this.Porduct_Click);
            // 
            // order
            // 
            this.order.Dock = System.Windows.Forms.DockStyle.Top;
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.order.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.order.IconColor = System.Drawing.Color.Gainsboro;
            this.order.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.order.IconSize = 32;
            this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.Location = new System.Drawing.Point(0, 200);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.order.Size = new System.Drawing.Size(220, 60);
            this.order.TabIndex = 2;
            this.order.Text = "Orders";
            this.order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.Order_Click);
            // 
            // dash
            // 
            this.dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash.FlatAppearance.BorderSize = 0;
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dash.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.dash.IconColor = System.Drawing.Color.Gainsboro;
            this.dash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dash.IconSize = 32;
            this.dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash.Location = new System.Drawing.Point(0, 140);
            this.dash.Name = "dash";
            this.dash.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dash.Size = new System.Drawing.Size(220, 60);
            this.dash.TabIndex = 1;
            this.dash.Text = "Dash Board";
            this.dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash.UseVisualStyleBackColor = true;
            this.dash.Click += new System.EventHandler(this.Dahs_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 576);
            this.Controls.Add(this.panelmenu);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton setting;
        private FontAwesome.Sharp.IconButton customer;
        private FontAwesome.Sharp.IconButton porduct;
        private FontAwesome.Sharp.IconButton order;
        private FontAwesome.Sharp.IconButton dash;
        private System.Windows.Forms.Panel panelLogo;
    }
}

