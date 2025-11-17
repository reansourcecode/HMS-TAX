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
            this._register_product_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._register_customer = new System.Windows.Forms.ToolStripMenuItem();
            this._report_list = new System.Windows.Forms.ToolStripMenuItem();
            this._logout_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._Exit_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._Inventory_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._ticket_PurchaseOrder_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._POS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._Authorized_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._authorizePO_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._Setting_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._permission_sub = new System.Windows.Forms.ToolStripMenuItem();
            this._About_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this._pos_sub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this._top_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.lblShowDeveloper.Size = new System.Drawing.Size(152, 22);
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
            this.lblShowUserlogin.Size = new System.Drawing.Size(92, 22);
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
            this.LblVersion.Size = new System.Drawing.Size(72, 22);
            this.LblVersion.Text = "Version 0.0.1";
            // 
            // _top_menu
            // 
            this._top_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_top_menu.BackgroundImage")));
            this._top_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._top_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this._top_menu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this._top_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._File_Menu,
            this._Inventory_Menu,
            this._POS_Menu,
            this._Authorized_Menu,
            this._Setting_Menu,
            this._About_Menu});
            this._top_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this._top_menu.Location = new System.Drawing.Point(0, 0);
            this._top_menu.Name = "_top_menu";
            this._top_menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this._top_menu.Size = new System.Drawing.Size(1911, 32);
            this._top_menu.TabIndex = 2;
            this._top_menu.Text = "menuStrip1";
            // 
            // _File_Menu
            // 
            this._File_Menu.CheckOnClick = true;
            this._File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._register_product_sub,
            this._register_customer,
            this._report_list,
            this._logout_sub,
            this._Exit_sub});
            this._File_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._File_Menu.ForeColor = System.Drawing.Color.Navy;
            this._File_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_File_Menu.Image")));
            this._File_Menu.Name = "_File_Menu";
            this._File_Menu.Size = new System.Drawing.Size(65, 26);
            this._File_Menu.Text = "&File";
            // 
            // _register_product_sub
            // 
            this._register_product_sub.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._register_product_sub.Image = ((System.Drawing.Image)(resources.GetObject("_register_product_sub.Image")));
            this._register_product_sub.Name = "_register_product_sub";
            this._register_product_sub.Size = new System.Drawing.Size(190, 24);
            this._register_product_sub.Text = "Register Product";
            this._register_product_sub.Click += new System.EventHandler(this._register_product_sub_Click);
            // 
            // _register_customer
            // 
            this._register_customer.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._register_customer.Image = ((System.Drawing.Image)(resources.GetObject("_register_customer.Image")));
            this._register_customer.Name = "_register_customer";
            this._register_customer.Size = new System.Drawing.Size(190, 24);
            this._register_customer.Text = "Register Customer";
            this._register_customer.Click += new System.EventHandler(this._register_customer_Click);
            // 
            // _report_list
            // 
            this._report_list.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._report_list.ForeColor = System.Drawing.Color.Navy;
            this._report_list.Image = ((System.Drawing.Image)(resources.GetObject("_report_list.Image")));
            this._report_list.Name = "_report_list";
            this._report_list.Size = new System.Drawing.Size(190, 24);
            this._report_list.Text = "Report list";
            this._report_list.Click += new System.EventHandler(this._report_list_Click);
            // 
            // _logout_sub
            // 
            this._logout_sub.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._logout_sub.ForeColor = System.Drawing.Color.Navy;
            this._logout_sub.Image = ((System.Drawing.Image)(resources.GetObject("_logout_sub.Image")));
            this._logout_sub.Name = "_logout_sub";
            this._logout_sub.Size = new System.Drawing.Size(190, 24);
            this._logout_sub.Text = "LogOut";
            this._logout_sub.Click += new System.EventHandler(this._logout_sub_Click);
            // 
            // _Exit_sub
            // 
            this._Exit_sub.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._Exit_sub.Image = ((System.Drawing.Image)(resources.GetObject("_Exit_sub.Image")));
            this._Exit_sub.Name = "_Exit_sub";
            this._Exit_sub.Size = new System.Drawing.Size(190, 24);
            this._Exit_sub.Text = "Exit";
            this._Exit_sub.Click += new System.EventHandler(this._Exit_sub_Click);
            // 
            // _Inventory_Menu
            // 
            this._Inventory_Menu.CheckOnClick = true;
            this._Inventory_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ticket_PurchaseOrder_sub});
            this._Inventory_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Inventory_Menu.ForeColor = System.Drawing.Color.Navy;
            this._Inventory_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_Inventory_Menu.Image")));
            this._Inventory_Menu.Name = "_Inventory_Menu";
            this._Inventory_Menu.Size = new System.Drawing.Size(100, 26);
            this._Inventory_Menu.Text = "&Inventory";
            // 
            // _ticket_PurchaseOrder_sub
            // 
            this._ticket_PurchaseOrder_sub.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._ticket_PurchaseOrder_sub.Image = ((System.Drawing.Image)(resources.GetObject("_ticket_PurchaseOrder_sub.Image")));
            this._ticket_PurchaseOrder_sub.Name = "_ticket_PurchaseOrder_sub";
            this._ticket_PurchaseOrder_sub.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this._ticket_PurchaseOrder_sub.Size = new System.Drawing.Size(265, 28);
            this._ticket_PurchaseOrder_sub.Text = "Ticket PurchaseOrder";
            this._ticket_PurchaseOrder_sub.Click += new System.EventHandler(this._ticket_PurchaseOrder_sub_Click);
            // 
            // _POS_Menu
            // 
            this._POS_Menu.CheckOnClick = true;
            this._POS_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._pos_sub});
            this._POS_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._POS_Menu.ForeColor = System.Drawing.Color.Navy;
            this._POS_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_POS_Menu.Image")));
            this._POS_Menu.Name = "_POS_Menu";
            this._POS_Menu.Size = new System.Drawing.Size(73, 26);
            this._POS_Menu.Text = "POS";
            // 
            // _Authorized_Menu
            // 
            this._Authorized_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._authorizePO_sub});
            this._Authorized_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Authorized_Menu.ForeColor = System.Drawing.Color.Navy;
            this._Authorized_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_Authorized_Menu.Image")));
            this._Authorized_Menu.Name = "_Authorized_Menu";
            this._Authorized_Menu.Size = new System.Drawing.Size(109, 26);
            this._Authorized_Menu.Text = "Authorized";
            // 
            // _authorizePO_sub
            // 
            this._authorizePO_sub.Image = ((System.Drawing.Image)(resources.GetObject("_authorizePO_sub.Image")));
            this._authorizePO_sub.Name = "_authorizePO_sub";
            this._authorizePO_sub.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this._authorizePO_sub.Size = new System.Drawing.Size(247, 24);
            this._authorizePO_sub.Text = "Authorize PO";
            this._authorizePO_sub.Click += new System.EventHandler(this._authorizePO_sub_Click);
            // 
            // _Setting_Menu
            // 
            this._Setting_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._permission_sub});
            this._Setting_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Setting_Menu.ForeColor = System.Drawing.Color.Navy;
            this._Setting_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_Setting_Menu.Image")));
            this._Setting_Menu.Name = "_Setting_Menu";
            this._Setting_Menu.Size = new System.Drawing.Size(84, 26);
            this._Setting_Menu.Text = "Setting";
            // 
            // _permission_sub
            // 
            this._permission_sub.Image = ((System.Drawing.Image)(resources.GetObject("_permission_sub.Image")));
            this._permission_sub.Name = "_permission_sub";
            this._permission_sub.Size = new System.Drawing.Size(143, 24);
            this._permission_sub.Text = "Permission";
            this._permission_sub.Click += new System.EventHandler(this._permission_sub_Click);
            // 
            // _About_Menu
            // 
            this._About_Menu.CheckOnClick = true;
            this._About_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._About_Menu.ForeColor = System.Drawing.Color.Navy;
            this._About_Menu.Image = ((System.Drawing.Image)(resources.GetObject("_About_Menu.Image")));
            this._About_Menu.Name = "_About_Menu";
            this._About_Menu.Size = new System.Drawing.Size(81, 26);
            this._About_Menu.Text = "About";
            // 
            // _pos_sub
            // 
            this._pos_sub.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._pos_sub.Image = ((System.Drawing.Image)(resources.GetObject("_pos_sub.Image")));
            this._pos_sub.Name = "_pos_sub";
            this._pos_sub.Size = new System.Drawing.Size(186, 28);
            this._pos_sub.Text = "Point of Sale";
            this._pos_sub.Click += new System.EventHandler(this._pos_sub_Click);
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
        private System.Windows.Forms.ToolStripMenuItem _permission_sub;
        private System.Windows.Forms.ToolStripMenuItem _register_customer;
        private System.Windows.Forms.ToolStripMenuItem _register_product_sub;
        private System.Windows.Forms.ToolStripMenuItem _Authorized_Menu;
        private System.Windows.Forms.ToolStripMenuItem _ticket_PurchaseOrder_sub;
        private System.Windows.Forms.ToolStripMenuItem _authorizePO_sub;
        private System.Windows.Forms.ToolStripMenuItem _report_list;
        private System.Windows.Forms.ToolStripMenuItem _pos_sub;
    }
}

