namespace HMS_TAX.HMS
{
    partial class FrmPurchaseOrderHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseOrderHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.po_date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboSupply = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCommit = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this._MenuFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._PurchaseOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._PO_delete = new System.Windows.Forms.ToolStripMenuItem();
            this._menu_short = new System.Windows.Forms.MenuStrip();
            this.Function = new System.Windows.Forms.ToolStripMenuItem();
            this._SearchProduct = new System.Windows.Forms.ToolStripMenuItem();
            this._addproductlist = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dgData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vPO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.po_date)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this._MenuFunction.SuspendLayout();
            this._menu_short.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.po_date);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.txtRemark);
            this.groupPanel2.Controls.Add(this.cboSupply);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtID);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(5, 41);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(469, 206);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 17;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(7, 79);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(81, 37);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 82;
            this.labelX2.Text = "PO Date :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // po_date
            // 
            // 
            // 
            // 
            this.po_date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.po_date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.po_date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.po_date.ButtonDropDown.Visible = true;
            this.po_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.po_date.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po_date.IsPopupCalendarOpen = false;
            this.po_date.Location = new System.Drawing.Point(94, 84);
            // 
            // 
            // 
            this.po_date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.po_date.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.po_date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.po_date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.po_date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.po_date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.po_date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.po_date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.po_date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.po_date.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.po_date.MonthCalendar.DisplayMonth = new System.DateTime(2025, 10, 1, 0, 0, 0, 0);
            this.po_date.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.po_date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.po_date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.po_date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.po_date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.po_date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.po_date.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.po_date.MonthCalendar.TodayButtonVisible = true;
            this.po_date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.po_date.Name = "po_date";
            this.po_date.Size = new System.Drawing.Size(200, 26);
            this.po_date.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.po_date.TabIndex = 2;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(7, 118);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(81, 37);
            this.labelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "Remark :";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtRemark.Location = new System.Drawing.Point(94, 119);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(371, 82);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtRemark.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRemark.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtRemark.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtRemark.WatermarkText = "ផ្សេងៗ";
            // 
            // cboSupply
            // 
            this.cboSupply.DisplayMember = "Text";
            this.cboSupply.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSupply.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboSupply.FormattingEnabled = true;
            this.cboSupply.ItemHeight = 20;
            this.cboSupply.Location = new System.Drawing.Point(94, 50);
            this.cboSupply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSupply.Name = "cboSupply";
            this.cboSupply.Size = new System.Drawing.Size(371, 26);
            this.cboSupply.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSupply.TabIndex = 1;
            this.cboSupply.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboSupply.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.cboSupply.WatermarkText = "បាទ / ចាស";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(7, 45);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(81, 37);
            this.labelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "Supply :";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(7, 10);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 37);
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
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtID.Location = new System.Drawing.Point(94, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(371, 26);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtID.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtID.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtID.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtID.WatermarkImage")));
            this.txtID.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtID.WatermarkText = "លេខសម្គាល់";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnCommit);
            this.groupPanel1.Controls.Add(this.btnNew);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(480, 41);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(137, 206);
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
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 18;
            // 
            // btnCommit
            // 
            this.btnCommit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnCommit.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCommit.HoverImage")));
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnCommit.Location = new System.Drawing.Point(9, 65);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(116, 40);
            this.btnCommit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "Commit";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnNew.Location = new System.Drawing.Point(9, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 40);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Navy;
            this.labelX4.Image = ((System.Drawing.Image)(resources.GetObject("labelX4.Image")));
            this.labelX4.Location = new System.Drawing.Point(49, -2);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.SingleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX4.Size = new System.Drawing.Size(331, 36);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "Purchase Tickets →";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._PurchaseOrder,
            this.toolStripSeparator1,
            this._PO_delete});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(186, 70);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _PurchaseOrder
            // 
            this._PurchaseOrder.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._PurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("_PurchaseOrder.Image")));
            this._PurchaseOrder.Name = "_PurchaseOrder";
            this._PurchaseOrder.Size = new System.Drawing.Size(185, 30);
            this._PurchaseOrder.Text = "PurchaseOrder ";
            this._PurchaseOrder.Click += new System.EventHandler(this._PurchaseOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // _PO_delete
            // 
            this._PO_delete.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this._PO_delete.Image = ((System.Drawing.Image)(resources.GetObject("_PO_delete.Image")));
            this._PO_delete.Name = "_PO_delete";
            this._PO_delete.Size = new System.Drawing.Size(185, 30);
            this._PO_delete.Text = "Delete";
            this._PO_delete.Click += new System.EventHandler(this._PO_delete_Click);
            // 
            // _menu_short
            // 
            this._menu_short.AllowMerge = false;
            this._menu_short.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._menu_short.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._menu_short.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Function});
            this._menu_short.Location = new System.Drawing.Point(0, 0);
            this._menu_short.Name = "_menu_short";
            this._menu_short.Size = new System.Drawing.Size(672, 24);
            this._menu_short.Stretch = false;
            this._menu_short.TabIndex = 31;
            this._menu_short.Text = "menuStrip1";
            this._menu_short.Visible = false;
            // 
            // Function
            // 
            this.Function.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SearchProduct,
            this._addproductlist,
            this.ExitMenu});
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(66, 20);
            this.Function.Text = "Function";
            // 
            // _SearchProduct
            // 
            this._SearchProduct.Name = "_SearchProduct";
            this._SearchProduct.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this._SearchProduct.Size = new System.Drawing.Size(173, 22);
            this._SearchProduct.Text = "Search Product";
            // 
            // _addproductlist
            // 
            this._addproductlist.Name = "_addproductlist";
            this._addproductlist.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._addproductlist.Size = new System.Drawing.Size(173, 22);
            this._addproductlist.Text = "Add Product";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ExitMenu.Size = new System.Drawing.Size(173, 22);
            this.ExitMenu.Text = "Exit";
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
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vPO_ID,
            this.vSupply,
            this.vDate,
            this.vRemark});
            this.dgData.ContextMenuStrip = this._MenuFunction;
            this.dgData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgData.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgData.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.Location = new System.Drawing.Point(0, 254);
            this.dgData.Margin = new System.Windows.Forms.Padding(4);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersVisible = false;
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(660, 256);
            this.dgData.StateCommon.Background.Color1 = System.Drawing.Color.MistyRose;
            this.dgData.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgData.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.dgData.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.dgData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.MistyRose;
            this.dgData.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dgData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.MistyRose;
            this.dgData.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgData.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.dgData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DarkBlue;
            this.dgData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dgData.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.MistyRose;
            this.dgData.StateCommon.HeaderRow.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgData.StateCommon.HeaderRow.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.dgData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgData.StateNormal.Background.Color1 = System.Drawing.Color.MistyRose;
            this.dgData.StateNormal.Background.Color2 = System.Drawing.Color.White;
            this.dgData.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgData.StateNormal.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dgData.StateNormal.HeaderColumn.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.dgData.StateNormal.HeaderColumn.Border.Rounding = 5;
            this.dgData.StateNormal.HeaderRow.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.dgData.StateNormal.HeaderRow.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgData.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgData.StateNormal.HeaderRow.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgData.StateNormal.HeaderRow.Border.Rounding = 5;
            this.dgData.TabIndex = 34;
            this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentDoubleClick);
            // 
            // vPO_ID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vPO_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.vPO_ID.HeaderText = "ID";
            this.vPO_ID.MinimumWidth = 6;
            this.vPO_ID.Name = "vPO_ID";
            // 
            // vSupply
            // 
            this.vSupply.HeaderText = "Supply";
            this.vSupply.Name = "vSupply";
            // 
            // vDate
            // 
            this.vDate.HeaderText = "Date";
            this.vDate.Name = "vDate";
            // 
            // vRemark
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vRemark.DefaultCellStyle = dataGridViewCellStyle2;
            this.vRemark.HeaderText = "Reamark";
            this.vRemark.Name = "vRemark";
            // 
            // FrmPurchaseOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(660, 511);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this._menu_short);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurchaseOrderHistory";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateActive.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Border.Color1 = System.Drawing.Color.MistyRose;
            this.StateActive.Border.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateCommon.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateCommon.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateCommon.Border.Color1 = System.Drawing.Color.MistyRose;
            this.StateCommon.Border.Color2 = System.Drawing.Color.MistyRose;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateInactive.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateInactive.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateInactive.Border.Color1 = System.Drawing.Color.MistyRose;
            this.StateInactive.Border.Color2 = System.Drawing.Color.MistyRose;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateInactive.Header.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateInactive.Header.Border.Color1 = System.Drawing.Color.Navy;
            this.StateInactive.Header.Border.Color2 = System.Drawing.Color.MistyRose;
            this.StateInactive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateInactive.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "FrmPurchaseOrderHistory";
            this.Load += new System.EventHandler(this.FrmPurchaseOrderHistory_Load);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.po_date)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this._MenuFunction.ResumeLayout(false);
            this._menu_short.ResumeLayout(false);
            this._menu_short.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemark;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSupply;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput po_date;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnCommit;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.MenuStrip _menu_short;
        private System.Windows.Forms.ToolStripMenuItem Function;
        private System.Windows.Forms.ToolStripMenuItem _SearchProduct;
        private System.Windows.Forms.ToolStripMenuItem _addproductlist;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _PurchaseOrder;
        private System.Windows.Forms.ToolStripMenuItem _PO_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRemark;
    }
}