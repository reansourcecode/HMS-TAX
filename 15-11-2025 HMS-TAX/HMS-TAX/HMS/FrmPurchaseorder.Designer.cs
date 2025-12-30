namespace HMS_TAX.HMS
{
    partial class FrmPurchaseorder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gsysdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gprocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gstock = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gimg = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.vexpired_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbltotal = new DevComponents.DotNetBar.LabelX();
            this.lblInfo = new DevComponents.DotNetBar.LabelX();
            this.btnUnList = new System.Windows.Forms.PictureBox();
            this.cboProduct = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._menu_short = new System.Windows.Forms.MenuStrip();
            this._Add_to_list = new System.Windows.Forms.ToolStripMenuItem();
            this._add_list = new System.Windows.Forms.ToolStripMenuItem();
            this._PO_Commit = new System.Windows.Forms.ToolStripMenuItem();
            this._exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.vNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSysDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vStock = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOtherCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MenuFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._PO_Expired = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._PO_delete = new System.Windows.Forms.ToolStripMenuItem();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnList)).BeginInit();
            this._menu_short.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this._MenuFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnum
            // 
            this.gnum.HeaderText = "No";
            this.gnum.MinimumWidth = 6;
            this.gnum.Name = "gnum";
            this.gnum.Width = 125;
            // 
            // gsysdoc
            // 
            this.gsysdoc.HeaderText = "sysdocnum";
            this.gsysdoc.Name = "gsysdoc";
            this.gsysdoc.Visible = false;
            // 
            // gitem
            // 
            this.gitem.HeaderText = "Items";
            this.gitem.MinimumWidth = 6;
            this.gitem.Name = "gitem";
            this.gitem.Width = 125;
            // 
            // gprocode
            // 
            this.gprocode.HeaderText = "Pro_id";
            this.gprocode.Name = "gprocode";
            // 
            // gbarcode
            // 
            this.gbarcode.HeaderText = "Barcode";
            this.gbarcode.MinimumWidth = 6;
            this.gbarcode.Name = "gbarcode";
            this.gbarcode.Width = 125;
            // 
            // gstock
            // 
            this.gstock.HeaderText = "Stock";
            this.gstock.Name = "gstock";
            this.gstock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gstock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gprice
            // 
            this.gprice.HeaderText = "Price";
            this.gprice.Name = "gprice";
            // 
            // gqty
            // 
            this.gqty.HeaderText = "Qty";
            this.gqty.Name = "gqty";
            // 
            // gdiscount
            // 
            this.gdiscount.HeaderText = "Discount";
            this.gdiscount.Name = "gdiscount";
            // 
            // gamount
            // 
            this.gamount.HeaderText = "Amount";
            this.gamount.Name = "gamount";
            // 
            // gimg
            // 
            this.gimg.HeaderText = "Delete";
            this.gimg.Name = "gimg";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.kryptonWrapLabel1);
            this.groupPanel1.Controls.Add(this.vexpired_date);
            this.groupPanel1.Controls.Add(this.lbltotal);
            this.groupPanel1.Controls.Add(this.lblInfo);
            this.groupPanel1.Controls.Add(this.btnUnList);
            this.groupPanel1.Controls.Add(this.cboProduct);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtID);
            this.groupPanel1.Location = new System.Drawing.Point(1, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1100, 111);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 18;
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonWrapLabel1.Image")));
            this.kryptonWrapLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(854, 6);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(103, 15);
            this.kryptonWrapLabel1.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.kryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.kryptonWrapLabel1.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonWrapLabel1.StateNormal.TextColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Text = "        F7 : Commit  ";
            // 
            // vexpired_date
            // 
            this.vexpired_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vexpired_date.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.vexpired_date.Location = new System.Drawing.Point(567, 48);
            this.vexpired_date.Name = "vexpired_date";
            this.vexpired_date.Size = new System.Drawing.Size(227, 28);
            this.vexpired_date.StateActive.Content.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vexpired_date.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vexpired_date.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.vexpired_date.StateNormal.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vexpired_date.TabIndex = 96;
            this.vexpired_date.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            // 
            // lbltotal
            // 
            // 
            // 
            // 
            this.lbltotal.BackgroundStyle.Class = "";
            this.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbltotal.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbltotal.Location = new System.Drawing.Point(651, 85);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(231, 22);
            this.lbltotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lbltotal.TabIndex = 97;
            this.lbltotal.Text = ". . .";
            // 
            // lblInfo
            // 
            // 
            // 
            // 
            this.lblInfo.BackgroundStyle.Class = "";
            this.lblInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInfo.Font = new System.Drawing.Font("Khmer OS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInfo.Location = new System.Drawing.Point(88, 85);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(472, 22);
            this.lblInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblInfo.TabIndex = 95;
            this.lblInfo.Text = ". . .";
            // 
            // btnUnList
            // 
            this.btnUnList.BackColor = System.Drawing.Color.Transparent;
            this.btnUnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnList.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnUnList.ErrorImage")));
            this.btnUnList.Image = ((System.Drawing.Image)(resources.GetObject("btnUnList.Image")));
            this.btnUnList.Location = new System.Drawing.Point(798, 14);
            this.btnUnList.Name = "btnUnList";
            this.btnUnList.Size = new System.Drawing.Size(22, 22);
            this.btnUnList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUnList.TabIndex = 93;
            this.btnUnList.TabStop = false;
            this.btnUnList.Click += new System.EventHandler(this.btnUnList_Click);
            // 
            // cboProduct
            // 
            this.cboProduct.DisplayMember = "Text";
            this.cboProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.ItemHeight = 23;
            this.cboProduct.Location = new System.Drawing.Point(87, 46);
            this.cboProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(314, 29);
            this.cboProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboProduct.TabIndex = 19;
            this.cboProduct.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboProduct.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.cboProduct.WatermarkText = "បាទ / ចាស";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Cascadia Code", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(424, 44);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(136, 33);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "Expired Date :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Cascadia Code", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(16, 43);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(61, 33);
            this.labelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "Name :";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Cascadia Code", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(16, 5);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 33);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "ID :";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtID.Location = new System.Drawing.Point(87, 11);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(707, 29);
            this.txtID.TabIndex = 10;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtID.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtID.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtID.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtID.WatermarkImage")));
            this.txtID.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtID.WatermarkText = "លេខសម្គាល់";
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // _menu_short
            // 
            this._menu_short.Dock = System.Windows.Forms.DockStyle.Right;
            this._menu_short.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._menu_short.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._menu_short.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Add_to_list});
            this._menu_short.Location = new System.Drawing.Point(1089, 0);
            this._menu_short.Name = "_menu_short";
            this._menu_short.Size = new System.Drawing.Size(126, 619);
            this._menu_short.TabIndex = 114;
            this._menu_short.Visible = false;
            // 
            // _Add_to_list
            // 
            this._Add_to_list.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._add_list,
            this._PO_Commit,
            this._exit});
            this._Add_to_list.Name = "_Add_to_list";
            this._Add_to_list.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this._Add_to_list.Size = new System.Drawing.Size(59, 19);
            this._Add_to_list.Text = "Function";
            // 
            // _add_list
            // 
            this._add_list.Name = "_add_list";
            this._add_list.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._add_list.Size = new System.Drawing.Size(138, 22);
            this._add_list.Text = "Add List";
            this._add_list.Click += new System.EventHandler(this._add_list_Click);
            // 
            // _PO_Commit
            // 
            this._PO_Commit.Name = "_PO_Commit";
            this._PO_Commit.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this._PO_Commit.Size = new System.Drawing.Size(138, 22);
            this._PO_Commit.Text = "Commit";
            this._PO_Commit.Click += new System.EventHandler(this._PO_Commit_Click);
            // 
            // _exit
            // 
            this._exit.Name = "_exit";
            this._exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this._exit.Size = new System.Drawing.Size(138, 22);
            this._exit.Text = "Exit";
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToOrderColumns = true;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNum,
            this.vSysDocNum,
            this.vProID,
            this.vName,
            this.vStock,
            this.vCost,
            this.vOtherCost,
            this.vQty,
            this.vDiscount,
            this.vAmount,
            this.vExp});
            this.dgData.ContextMenuStrip = this._MenuFunction;
            this.dgData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgData.Location = new System.Drawing.Point(0, 119);
            this.dgData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersVisible = false;
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(1109, 500);
            this.dgData.StandardTab = true;
            this.dgData.TabIndex = 115;
            this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellClick);
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellEndEdit);
            this.dgData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgData_KeyDown);
            // 
            // vNum
            // 
            this.vNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vNum.HeaderText = "Noº";
            this.vNum.Name = "vNum";
            this.vNum.Width = 61;
            // 
            // vSysDocNum
            // 
            this.vSysDocNum.HeaderText = "SysDocNum";
            this.vSysDocNum.Name = "vSysDocNum";
            // 
            // vProID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vProID.DefaultCellStyle = dataGridViewCellStyle1;
            this.vProID.HeaderText = "Pro.ID";
            this.vProID.Name = "vProID";
            // 
            // vName
            // 
            this.vName.HeaderText = "Item";
            this.vName.Name = "vName";
            // 
            // vStock
            // 
            this.vStock.HeaderText = "Stock";
            this.vStock.Name = "vStock";
            this.vStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vCost
            // 
            this.vCost.HeaderText = "Cost";
            this.vCost.Name = "vCost";
            // 
            // vOtherCost
            // 
            this.vOtherCost.HeaderText = "Exp";
            this.vOtherCost.Name = "vOtherCost";
            // 
            // vQty
            // 
            this.vQty.HeaderText = "Qty";
            this.vQty.Name = "vQty";
            // 
            // vDiscount
            // 
            this.vDiscount.HeaderText = "Discount";
            this.vDiscount.Name = "vDiscount";
            // 
            // vAmount
            // 
            this.vAmount.HeaderText = "Amount";
            this.vAmount.Name = "vAmount";
            // 
            // vExp
            // 
            this.vExp.HeaderText = "Expired";
            this.vExp.Name = "vExp";
            // 
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._PO_Expired,
            this.toolStripSeparator2,
            this._PO_delete});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(176, 54);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _PO_Expired
            // 
            this._PO_Expired.Image = ((System.Drawing.Image)(resources.GetObject("_PO_Expired.Image")));
            this._PO_Expired.Name = "_PO_Expired";
            this._PO_Expired.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this._PO_Expired.Size = new System.Drawing.Size(175, 22);
            this._PO_Expired.Text = "Edit Expired";
            this._PO_Expired.Click += new System.EventHandler(this._PO_Expired_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // _PO_delete
            // 
            this._PO_delete.Image = ((System.Drawing.Image)(resources.GetObject("_PO_delete.Image")));
            this._PO_delete.Name = "_PO_delete";
            this._PO_delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._PO_delete.Size = new System.Drawing.Size(175, 22);
            this._PO_delete.Text = "Delete";
            this._PO_delete.Click += new System.EventHandler(this._PO_delete_Click);
            // 
            // _styleform
            // 
            this._styleform.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this._styleform.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._styleform.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.Image")));
            this._styleform.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this._styleform.ButtonSpecs.FormClose.ToolTipTitle = "Close";
            this._styleform.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this._styleform.FormStyles.FormMain.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this._styleform.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this._styleform.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this._styleform.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            // 
            // FrmPurchaseorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1109, 619);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this._menu_short);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurchaseorder";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPurchaseorder";
            this.Load += new System.EventHandler(this.FrmPurchaseorder_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnList)).EndInit();
            this._menu_short.ResumeLayout(false);
            this._menu_short.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this._MenuFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn gnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gsysdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gprocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gbarcode;
        private System.Windows.Forms.DataGridViewComboBoxColumn gstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn gprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamount;
        private System.Windows.Forms.DataGridViewImageColumn gimg;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboProduct;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private System.Windows.Forms.PictureBox btnUnList;
        private System.Windows.Forms.MenuStrip _menu_short;
        private System.Windows.Forms.ToolStripMenuItem _Add_to_list;
        private System.Windows.Forms.ToolStripMenuItem _add_list;
        private System.Windows.Forms.ToolStripMenuItem _PO_Commit;
        private System.Windows.Forms.ToolStripMenuItem _exit;
        private DevComponents.DotNetBar.LabelX lblInfo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgData;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker vexpired_date;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _PO_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _PO_Expired;
        private DevComponents.DotNetBar.LabelX lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSysDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewComboBoxColumn vStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOtherCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn vQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vExp;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
    }
}