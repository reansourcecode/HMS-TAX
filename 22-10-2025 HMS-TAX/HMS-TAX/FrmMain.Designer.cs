namespace HMS_TAX
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblShowDeveloper = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblShowUserlogin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LblVersion = new System.Windows.Forms.ToolStripLabel();
            this._top_menu = new System.Windows.Forms.MenuStrip();
            this._File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._logout_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._Exit_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._Inventory_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._register_customer = new System.Windows.Forms.ToolStripMenuItem();
            this._POS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._Setting_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._permission_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._About_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._register_product_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this._top_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblShowDeveloper,
            this.toolStripSeparator1,
            this.lblShowUserlogin,
            this.toolStripSeparator2,
            this.LblVersion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 945);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1911, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblShowDeveloper
            // 
            this.lblShowDeveloper.ForeColor = System.Drawing.Color.Navy;
            this.lblShowDeveloper.Name = "lblShowDeveloper";
            this.lblShowDeveloper.Size = new System.Drawing.Size(225, 22);
            this.lblShowDeveloper.Text = "Developed by : REAN.CODE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblShowUserlogin
            // 
            this.lblShowUserlogin.Name = "lblShowUserlogin";
            this.lblShowUserlogin.Size = new System.Drawing.Size(135, 22);
            this.lblShowUserlogin.Text = "Logged : Admin";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // LblVersion
            // 
            this.LblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(126, 22);
            this.LblVersion.Text = "Version 0.0.1";
            // 
            // _top_menu
            // 
            this._top_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_top_menu.BackgroundImage")));
            this._top_menu.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._top_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._File_Menu,
            this._Inventory_Menu,
            this._POS_Menu,
            this._Setting_Menu,
            this._About_Menu});
            this._top_menu.Location = new System.Drawing.Point(0, 0);
            this._top_menu.Name = "_top_menu";
            this._top_menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this._top_menu.Size = new System.Drawing.Size(1911, 29);
            this._top_menu.TabIndex = 2;
            this._top_menu.Text = "menuStrip1";
            // 
            // _File_Menu
            // 
            this._File_Menu.CheckOnClick = true;
            this._File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._logout_sub,
            this._Exit_sub});
            this._File_Menu.ForeColor = System.Drawing.Color.Navy;
            this._File_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_File_Menu.Image")));
            this._File_Menu.Name = "_File_Menu";
            this._File_Menu.Size = new System.Drawing.Size(73, 23);
            this._File_Menu.Text = "&File";
            // 
            // _logout_sub
            // 
            this._logout_sub.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this._logout_sub.ForeColor = System.Drawing.Color.Navy;
            this._logout_sub.Image = ((System.Drawing.Image)(resources.GetObject("_logout_sub.Image")));
            this._logout_sub.Name = "_logout_sub";
            this._logout_sub.Size = new System.Drawing.Size(152, 24);
            this._logout_sub.Text = "LogOut";
            this._logout_sub.Click += new System.EventHandler(this._logout_sub_Click);
            // 
            // _Exit_sub
            // 
            this._Exit_sub.Image = ((System.Drawing.Image)(resources.GetObject("_Exit_sub.Image")));
            this._Exit_sub.Name = "_Exit_sub";
            this._Exit_sub.Size = new System.Drawing.Size(152, 24);
            this._Exit_sub.Text = "Exit";
            this._Exit_sub.Click += new System.EventHandler(this._Exit_sub_Click);
            // 
            // _Inventory_Menu
            // 
            this._Inventory_Menu.CheckOnClick = true;
            this._Inventory_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._register_customer,
            this._register_product_sub});
            this._Inventory_Menu.ForeColor = System.Drawing.Color.Navy;
            this._Inventory_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_Inventory_Menu.Image")));
            this._Inventory_Menu.Name = "_Inventory_Menu";
            this._Inventory_Menu.Size = new System.Drawing.Size(118, 23);
            this._Inventory_Menu.Text = "&Inventory";
            // 
            // _register_customer
            // 
            this._register_customer.Image = ((System.Drawing.Image)(resources.GetObject("_register_customer.Image")));
            this._register_customer.Name = "_register_customer";
            this._register_customer.Size = new System.Drawing.Size(231, 24);
            this._register_customer.Text = "Register Customer";
            this._register_customer.Click += new System.EventHandler(this._register_customer_Click);
            // 
            // _POS_Menu
            // 
            this._POS_Menu.CheckOnClick = true;
            this._POS_Menu.ForeColor = System.Drawing.Color.Navy;
            this._POS_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_POS_Menu.Image")));
            this._POS_Menu.Name = "_POS_Menu";
            this._POS_Menu.Size = new System.Drawing.Size(64, 23);
            this._POS_Menu.Text = "POS";
            // 
            // _Setting_Menu
            // 
            this._Setting_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._permission_sub});
            this._Setting_Menu.ForeColor = System.Drawing.Color.Navy;
            this._Setting_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_Setting_Menu.Image")));
            this._Setting_Menu.Name = "_Setting_Menu";
            this._Setting_Menu.Size = new System.Drawing.Size(100, 23);
            this._Setting_Menu.Text = "Setting";
            // 
            // _permission_sub
            // 
            this._permission_sub.Image = ((System.Drawing.Image)(resources.GetObject("_permission_sub.Image")));
            this._permission_sub.Name = "_permission_sub";
            this._permission_sub.Size = new System.Drawing.Size(168, 24);
            this._permission_sub.Text = "Permission";
            this._permission_sub.Click += new System.EventHandler(this._permission_sub_Click);
            // 
            // _About_Menu
            // 
            this._About_Menu.CheckOnClick = true;
            this._About_Menu.ForeColor = System.Drawing.Color.Navy;
            this._About_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_About_Menu.Image")));
            this._About_Menu.Name = "_About_Menu";
            this._About_Menu.Size = new System.Drawing.Size(82, 23);
            this._About_Menu.Text = "About";
            // 
            // _register_product_sub
            // 
            this._register_product_sub.Image = ((System.Drawing.Image)(resources.GetObject("_register_product_sub.Image")));
            this._register_product_sub.Name = "_register_product_sub";
            this._register_product_sub.Size = new System.Drawing.Size(231, 24);
            this._register_product_sub.Text = "Register Product";
            this._register_product_sub.Click += new System.EventHandler(this._register_product_sub_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1911, 970);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._top_menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this._top_menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital management system";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._top_menu.ResumeLayout(false);
            this._top_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip _top_menu;
        private System.Windows.Forms.ToolStripMenuItem _File_Menu;
        private System.Windows.Forms.ToolStripMenuItem _Inventory_Menu;
        private System.Windows.Forms.ToolStripMenuItem _About_Menu;
        private System.Windows.Forms.ToolStripMenuItem _logout_sub;
        private System.Windows.Forms.ToolStripMenuItem _POS_Menu;
        private System.Windows.Forms.ToolStripMenuItem _Setting_Menu;
        private System.Windows.Forms.ToolStripLabel lblShowDeveloper;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblShowUserlogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel LblVersion;
        private System.Windows.Forms.ToolStripMenuItem _Exit_sub;
        private System.Windows.Forms.ToolStripMenuItem _register_customer;
        private System.Windows.Forms.ToolStripMenuItem _permission_sub;
        private System.Windows.Forms.ToolStripMenuItem _register_product_sub;
    }
}

