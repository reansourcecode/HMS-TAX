namespace HMS_TAX.HMS_Auth
{
    partial class FrmAuthPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthPO));
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgSearch = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTranCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtsupply = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtRemark = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOtherCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gb = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtInputter = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCommit = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb.Panel)).BeginInit();
            this.gb.Panel.SuspendLayout();
            this.gb.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(25, 85);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 22);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel4.TabIndex = 109;
            this.kryptonLabel4.Values.Text = "Remark";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(25, 48);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(54, 22);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel2.TabIndex = 108;
            this.kryptonLabel2.Values.Text = "Supply";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(25, 12);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 22);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kryptonLabel3.TabIndex = 106;
            this.kryptonLabel3.Values.Text = "PO.ID";
            // 
            // dgSearch
            // 
            this.dgSearch.AllowUserToAddRows = false;
            this.dgSearch.AllowUserToDeleteRows = false;
            this.dgSearch.AllowUserToResizeColumns = false;
            this.dgSearch.AllowUserToResizeRows = false;
            this.dgSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgSearch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.ColumnHeadersVisible = false;
            this.dgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNo,
            this.vTranCode,
            this.vSupply});
            this.dgSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgSearch.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgSearch.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgSearch.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dgSearch.Location = new System.Drawing.Point(727, 43);
            this.dgSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.ReadOnly = true;
            this.dgSearch.RowHeadersVisible = false;
            this.dgSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSearch.Size = new System.Drawing.Size(285, 61);
            this.dgSearch.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgSearch.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgSearch.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgSearch.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Red;
            this.dgSearch.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgSearch.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSearch.StateCommon.HeaderRow.Back.ColorAngle = 10F;
            this.dgSearch.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateCommon.HeaderRow.Border.Rounding = 10;
            this.dgSearch.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSearch.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateNormal.DataCell.Border.Rounding = 10;
            this.dgSearch.StateNormal.HeaderColumn.Border.ColorAngle = 10F;
            this.dgSearch.StateNormal.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgSearch.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateNormal.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dgSearch.StateNormal.HeaderColumn.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgSearch.StateNormal.HeaderColumn.Border.Rounding = 10;
            this.dgSearch.StateNormal.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgSearch.StateNormal.HeaderColumn.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dgSearch.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateNormal.HeaderRow.Border.Rounding = 10;
            this.dgSearch.StatePressed.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StatePressed.HeaderColumn.Border.Rounding = 10;
            this.dgSearch.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgSearch.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgSearch.StateTracking.HeaderColumn.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgSearch.StateTracking.HeaderColumn.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dgSearch.StateTracking.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateTracking.HeaderColumn.Border.Rounding = 10;
            this.dgSearch.StateTracking.HeaderRow.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dgSearch.StateTracking.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgSearch.StateTracking.HeaderRow.Border.Rounding = 10;
            this.dgSearch.TabIndex = 112;
            this.dgSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellClick);
            this.dgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellContentClick);
            // 
            // vNo
            // 
            this.vNo.HeaderText = "No";
            this.vNo.Name = "vNo";
            this.vNo.ReadOnly = true;
            // 
            // vTranCode
            // 
            this.vTranCode.HeaderText = "PO ID";
            this.vTranCode.Name = "vTranCode";
            this.vTranCode.ReadOnly = true;
            // 
            // vSupply
            // 
            this.vSupply.HeaderText = "Supply";
            this.vSupply.Name = "vSupply";
            this.vSupply.ReadOnly = true;
            // 
            // btnimage
            // 
            this.btnimage.AllowFocused = false;
            this.btnimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnimage.AutoSizeHeight = true;
            this.btnimage.BorderRadius = 15;
            this.btnimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimage.Image = ((System.Drawing.Image)(resources.GetObject("btnimage.Image")));
            this.btnimage.IsCircle = true;
            this.btnimage.Location = new System.Drawing.Point(483, 10);
            this.btnimage.Margin = new System.Windows.Forms.Padding(4);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(31, 31);
            this.btnimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnimage.TabIndex = 48;
            this.btnimage.TabStop = false;
            this.btnimage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // txtsupply
            // 
            this.txtsupply.Location = new System.Drawing.Point(95, 45);
            this.txtsupply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsupply.Name = "txtsupply";
            this.txtsupply.ReadOnly = true;
            this.txtsupply.Size = new System.Drawing.Size(424, 31);
            this.txtsupply.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtsupply.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsupply.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsupply.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtsupply.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtsupply.StateCommon.Border.Rounding = 10;
            this.txtsupply.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtsupply.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtsupply.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtsupply.TabIndex = 45;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(95, 82);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(424, 31);
            this.txtRemark.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRemark.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRemark.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRemark.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRemark.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRemark.StateCommon.Border.Rounding = 10;
            this.txtRemark.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtRemark.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtRemark.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtRemark.TabIndex = 46;
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vID,
            this.vName,
            this.vStock,
            this.vCost,
            this.vOtherCost,
            this.vQty,
            this.vDis,
            this.vAmount,
            this.vExpired});
            this.dgData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgData.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgData.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgData.Location = new System.Drawing.Point(0, 186);
            this.dgData.Margin = new System.Windows.Forms.Padding(4);
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.RowHeadersVisible = false;
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgData.Size = new System.Drawing.Size(1007, 423);
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
            this.dgData.TabIndex = 111;
            // 
            // vID
            // 
            this.vID.HeaderText = "Id";
            this.vID.MinimumWidth = 6;
            this.vID.Name = "vID";
            this.vID.ReadOnly = true;
            this.vID.Width = 125;
            // 
            // vName
            // 
            this.vName.HeaderText = "Items";
            this.vName.MinimumWidth = 6;
            this.vName.Name = "vName";
            this.vName.ReadOnly = true;
            this.vName.Width = 125;
            // 
            // vStock
            // 
            this.vStock.HeaderText = "Stock";
            this.vStock.Name = "vStock";
            this.vStock.ReadOnly = true;
            // 
            // vCost
            // 
            this.vCost.HeaderText = "Cost";
            this.vCost.Name = "vCost";
            this.vCost.ReadOnly = true;
            // 
            // vOtherCost
            // 
            this.vOtherCost.HeaderText = "Exp";
            this.vOtherCost.Name = "vOtherCost";
            this.vOtherCost.ReadOnly = true;
            // 
            // vQty
            // 
            this.vQty.HeaderText = "Qty";
            this.vQty.Name = "vQty";
            this.vQty.ReadOnly = true;
            // 
            // vDis
            // 
            this.vDis.HeaderText = "Discount";
            this.vDis.Name = "vDis";
            this.vDis.ReadOnly = true;
            // 
            // vAmount
            // 
            this.vAmount.HeaderText = "Amount";
            this.vAmount.Name = "vAmount";
            this.vAmount.ReadOnly = true;
            // 
            // vExpired
            // 
            this.vExpired.HeaderText = "Expired";
            this.vExpired.Name = "vExpired";
            this.vExpired.ReadOnly = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(95, 9);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(385, 31);
            this.txtid.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtid.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtid.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtid.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtid.StateCommon.Border.Rounding = 10;
            this.txtid.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtid.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtid.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtid.TabIndex = 39;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // gb
            // 
            this.gb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.gb.CaptionOverlap = 0.66D;
            this.gb.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.gb.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.gb.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.gb.Location = new System.Drawing.Point(0, -4);
            this.gb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb.Name = "gb";
            // 
            // gb.Panel
            // 
            this.gb.Panel.Controls.Add(this.kryptonLabel1);
            this.gb.Panel.Controls.Add(this.txtInputter);
            this.gb.Panel.Controls.Add(this.kryptonLabel4);
            this.gb.Panel.Controls.Add(this.kryptonLabel2);
            this.gb.Panel.Controls.Add(this.kryptonLabel3);
            this.gb.Panel.Controls.Add(this.btnimage);
            this.gb.Panel.Controls.Add(this.txtRemark);
            this.gb.Panel.Controls.Add(this.txtsupply);
            this.gb.Panel.Controls.Add(this.txtid);
            this.gb.Size = new System.Drawing.Size(579, 183);
            this.gb.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.gb.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gb.StateCommon.Border.Rounding = 10;
            this.gb.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gb.TabIndex = 110;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 119);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(72, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 111;
            this.kryptonLabel1.Values.Text = "Inputter";
            // 
            // txtInputter
            // 
            this.txtInputter.Location = new System.Drawing.Point(95, 119);
            this.txtInputter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputter.Name = "txtInputter";
            this.txtInputter.ReadOnly = true;
            this.txtInputter.Size = new System.Drawing.Size(424, 31);
            this.txtInputter.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtInputter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInputter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInputter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInputter.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtInputter.StateCommon.Border.Rounding = 10;
            this.txtInputter.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtInputter.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtInputter.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtInputter.TabIndex = 110;
            // 
            // _styleform
            // 
            this._styleform.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnCommit);
            this.groupPanel1.Controls.Add(this.btnNew);
            this.groupPanel1.Controls.Add(this.btnEdit);
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(585, 6);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(136, 173);
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
            this.groupPanel1.TabIndex = 113;
            // 
            // btnCommit
            // 
            this.btnCommit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCommit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCommit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommit.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnCommit.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnCommit.HoverImage")));
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnCommit.Location = new System.Drawing.Point(13, 63);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(111, 44);
            this.btnCommit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommit.TabIndex = 15;
            this.btnCommit.Text = "Approve";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnNew.Location = new System.Drawing.Point(13, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 44);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Clear";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnEdit.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.HoverImage")));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnEdit.Location = new System.Drawing.Point(13, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 44);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Reject";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmAuthPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1007, 609);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.gb);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAuthPO";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAuthPO";
            this.Load += new System.EventHandler(this.FrmAuthPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb.Panel)).EndInit();
            this.gb.Panel.ResumeLayout(false);
            this.gb.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gb)).EndInit();
            this.gb.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgSearch;
        private Bunifu.UI.WinForms.BunifuPictureBox btnimage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtsupply;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRemark;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgData;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtid;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gb;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInputter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTranCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSupply;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnCommit;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOtherCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn vQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vExpired;
    }
}