namespace HMS_TAX.HMS_Auth
{
    partial class FrmAuthPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dgView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbatch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrcp_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinputter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MenuFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._Approved = new System.Windows.Forms.ToolStripMenuItem();
            this._seperate01 = new System.Windows.Forms.ToolStripSeparator();
            this._Rejected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dg_action = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCommit = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnReject = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this._MenuFunction.SuspendLayout();
            this.dg_action.SuspendLayout();
            this.SuspendLayout();
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
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToResizeColumns = false;
            this.dgView.AllowUserToResizeRows = false;
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNum,
            this.vName,
            this.vstock,
            this.vprice,
            this.vqty,
            this.vdiscount,
            this.vamount,
            this.vbatch_id});
            this.dgView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgView.Location = new System.Drawing.Point(0, 251);
            this.dgView.Margin = new System.Windows.Forms.Padding(4);
            this.dgView.MultiSelect = false;
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersVisible = false;
            this.dgView.RowHeadersWidth = 51;
            this.dgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(1005, 311);
            this.dgView.StateCommon.Background.Color1 = System.Drawing.Color.MistyRose;
            this.dgView.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgView.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.dgView.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.dgView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgView.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgView.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgView.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgView.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.dgView.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DarkBlue;
            this.dgView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dgView.StateCommon.HeaderRow.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgView.StateCommon.HeaderRow.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.dgView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgView.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgView.StateNormal.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dgView.StateNormal.HeaderColumn.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.dgView.StateNormal.HeaderColumn.Border.Rounding = 5;
            this.dgView.StateNormal.HeaderRow.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.dgView.StateNormal.HeaderRow.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgView.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgView.StateNormal.HeaderRow.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgView.StateNormal.HeaderRow.Border.Rounding = 5;
            this.dgView.TabIndex = 115;
            // 
            // vNum
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vNum.DefaultCellStyle = dataGridViewCellStyle14;
            this.vNum.HeaderText = "No";
            this.vNum.MinimumWidth = 6;
            this.vNum.Name = "vNum";
            // 
            // vName
            // 
            this.vName.HeaderText = "Items";
            this.vName.MinimumWidth = 6;
            this.vName.Name = "vName";
            // 
            // vstock
            // 
            this.vstock.HeaderText = "Stock";
            this.vstock.Name = "vstock";
            // 
            // vprice
            // 
            this.vprice.HeaderText = "Price";
            this.vprice.Name = "vprice";
            // 
            // vqty
            // 
            this.vqty.HeaderText = "Qty";
            this.vqty.Name = "vqty";
            // 
            // vdiscount
            // 
            this.vdiscount.HeaderText = "Discount";
            this.vdiscount.Name = "vdiscount";
            // 
            // vamount
            // 
            this.vamount.HeaderText = "Amount";
            this.vamount.Name = "vamount";
            // 
            // vbatch_id
            // 
            this.vbatch_id.HeaderText = "Batch iD";
            this.vbatch_id.Name = "vbatch_id";
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgData.ColumnHeadersHeight = 30;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gNum,
            this.vrcp_num,
            this.vcustomer,
            this.vinputter,
            this.vstatus});
            this.dgData.ContextMenuStrip = this._MenuFunction;
            this.dgData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgData.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgData.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.Location = new System.Drawing.Point(0, 1);
            this.dgData.Margin = new System.Windows.Forms.Padding(4);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersVisible = false;
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgData.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(597, 216);
            this.dgData.StateCommon.Background.Color1 = System.Drawing.Color.MistyRose;
            this.dgData.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgData.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.dgData.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.dgData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgData.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgData.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.dgData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DarkBlue;
            this.dgData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dgData.StateCommon.HeaderRow.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgData.StateCommon.HeaderRow.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.dgData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgData.TabIndex = 119;
            this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            // 
            // gNum
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gNum.DefaultCellStyle = dataGridViewCellStyle18;
            this.gNum.HeaderText = "Noº";
            this.gNum.Name = "gNum";
            // 
            // vrcp_num
            // 
            this.vrcp_num.HeaderText = "invoice";
            this.vrcp_num.Name = "vrcp_num";
            // 
            // vcustomer
            // 
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcustomer.DefaultCellStyle = dataGridViewCellStyle19;
            this.vcustomer.HeaderText = "Customer";
            this.vcustomer.Name = "vcustomer";
            // 
            // vinputter
            // 
            this.vinputter.HeaderText = "Inputter";
            this.vinputter.Name = "vinputter";
            // 
            // vstatus
            // 
            this.vstatus.HeaderText = "Status";
            this.vstatus.Name = "vstatus";
            // 
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Refresh,
            this.toolStripSeparator1,
            this._Approved,
            this._seperate01,
            this._Rejected,
            this.toolStripSeparator2});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(120, 88);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _Refresh
            // 
            this._Refresh.Image = ((System.Drawing.Image)(resources.GetObject("_Refresh.Image")));
            this._Refresh.Name = "_Refresh";
            this._Refresh.Size = new System.Drawing.Size(119, 22);
            this._Refresh.Text = "Refresh";
            this._Refresh.Click += new System.EventHandler(this._Refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // _Approved
            // 
            this._Approved.Image = ((System.Drawing.Image)(resources.GetObject("_Approved.Image")));
            this._Approved.Name = "_Approved";
            this._Approved.Size = new System.Drawing.Size(119, 22);
            this._Approved.Text = "Approve";
            this._Approved.Click += new System.EventHandler(this._Approved_Click);
            // 
            // _seperate01
            // 
            this._seperate01.Name = "_seperate01";
            this._seperate01.Size = new System.Drawing.Size(116, 6);
            // 
            // _Rejected
            // 
            this._Rejected.Image = ((System.Drawing.Image)(resources.GetObject("_Rejected.Image")));
            this._Rejected.Name = "_Rejected";
            this._Rejected.Size = new System.Drawing.Size(119, 22);
            this._Rejected.Text = "Reject";
            this._Rejected.Click += new System.EventHandler(this._Rejected_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSearch.Location = new System.Drawing.Point(0, 220);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1005, 29);
            this.txtSearch.TabIndex = 120;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSearch.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearch.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtSearch.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.WatermarkImage")));
            this.txtSearch.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSearch.WatermarkText = "ស្វែងរក Searching";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dg_action
            // 
            this.dg_action.CanvasColor = System.Drawing.SystemColors.Control;
            this.dg_action.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.dg_action.Controls.Add(this.btnCommit);
            this.dg_action.Controls.Add(this.btnNew);
            this.dg_action.Controls.Add(this.btnReject);
            this.dg_action.IsShadowEnabled = true;
            this.dg_action.Location = new System.Drawing.Point(604, 1);
            this.dg_action.Name = "dg_action";
            this.dg_action.Size = new System.Drawing.Size(136, 173);
            // 
            // 
            // 
            this.dg_action.Style.BackColorGradientAngle = 90;
            this.dg_action.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.dg_action.Style.BorderBottomWidth = 1;
            this.dg_action.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.dg_action.Style.BorderLeftWidth = 1;
            this.dg_action.Style.BorderRightWidth = 1;
            this.dg_action.Style.BorderTopWidth = 1;
            this.dg_action.Style.Class = "";
            this.dg_action.Style.CornerDiameter = 4;
            this.dg_action.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.dg_action.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.dg_action.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.dg_action.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.dg_action.StyleMouseDown.Class = "";
            this.dg_action.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dg_action.StyleMouseOver.Class = "";
            this.dg_action.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dg_action.TabIndex = 121;
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
            this.btnCommit.Location = new System.Drawing.Point(13, 63);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(113, 44);
            this.btnCommit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommit.TabIndex = 15;
            this.btnCommit.Text = "Approve";
            this.btnCommit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCommit.Click += new System.EventHandler(this._Approved_Click);
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
            this.btnNew.Location = new System.Drawing.Point(13, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 44);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Clear";
            this.btnNew.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnNew.Click += new System.EventHandler(this._Refresh_Click);
            // 
            // btnReject
            // 
            this.btnReject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnReject.Image = ((System.Drawing.Image)(resources.GetObject("btnReject.Image")));
            this.btnReject.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnReject.Location = new System.Drawing.Point(13, 116);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(113, 44);
            this.btnReject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReject.TabIndex = 14;
            this.btnReject.Text = "Reject";
            this.btnReject.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnReject.Click += new System.EventHandler(this._Rejected_Click);
            // 
            // FrmAuthPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1005, 562);
            this.Controls.Add(this.dg_action);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.dgView);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAuthPOS";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateActive.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateActive.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.StateActive.Border.Color1 = System.Drawing.Color.MistyRose;
            this.StateActive.Border.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.MistyRose;
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Header.Border.Color1 = System.Drawing.Color.MistyRose;
            this.StateActive.Header.Border.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateInactive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.Text = "FrmAuthPOS";
            this.Load += new System.EventHandler(this.FrmAuthPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this._MenuFunction.ResumeLayout(false);
            this.dg_action.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgView;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgData;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn vprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn vqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatch_id;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _Approved;
        private System.Windows.Forms.ToolStripSeparator _seperate01;
        private System.Windows.Forms.ToolStripMenuItem _Rejected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _Refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrcp_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinputter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vstatus;
        private DevComponents.DotNetBar.Controls.GroupPanel dg_action;
        private DevComponents.DotNetBar.ButtonX btnCommit;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnReject;
    }
}