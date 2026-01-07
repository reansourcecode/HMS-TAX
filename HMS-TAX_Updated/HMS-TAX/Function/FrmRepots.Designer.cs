namespace HMS_TAX.Function
{
    partial class FrmRepots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepots));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.rtpData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vrpt_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrpt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrpt_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblShow = new DevComponents.DotNetBar.LabelX();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cboStock = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboProduct = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboLine = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboMolecule = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboPacking = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboCustomer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbosupply = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.progressbarsetup = new Bunifu.UI.WinForms.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.rtpData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMolecule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosupply)).BeginInit();
            this.SuspendLayout();
            // 
            // _styleform
            // 
            this._styleform.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._styleform.ButtonSpecs.FormClose.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImageNormal = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImageNormal")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this._styleform.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this._styleform.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            this._styleform.ButtonSpecs.FormClose.ToolTipTitle = "Close";
            this._styleform.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("_styleform.ButtonSpecs.FormMin.Image")));
            this._styleform.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this._styleform.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this._styleform.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this._styleform.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._styleform.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // rtpData
            // 
            this.rtpData.AllowUserToAddRows = false;
            this.rtpData.AllowUserToDeleteRows = false;
            this.rtpData.AllowUserToResizeColumns = false;
            this.rtpData.AllowUserToResizeRows = false;
            this.rtpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rtpData.ColumnHeadersVisible = false;
            this.rtpData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vrpt_name,
            this.vrpt_id,
            this.vrpt_title});
            this.rtpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtpData.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtpData.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.rtpData.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.rtpData.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.rtpData.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.rtpData.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.rtpData.Location = new System.Drawing.Point(0, 0);
            this.rtpData.MultiSelect = false;
            this.rtpData.Name = "rtpData";
            this.rtpData.ReadOnly = true;
            this.rtpData.RowHeadersVisible = false;
            this.rtpData.RowHeadersWidth = 51;
            this.rtpData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rtpData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rtpData.Size = new System.Drawing.Size(341, 767);
            this.rtpData.StateCommon.Background.Color1 = System.Drawing.Color.MistyRose;
            this.rtpData.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.rtpData.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.rtpData.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.rtpData.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.rtpData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rtpData.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rtpData.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtpData.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.rtpData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DarkBlue;
            this.rtpData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rtpData.StateCommon.HeaderRow.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.rtpData.StateCommon.HeaderRow.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.rtpData.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtpData.StateNormal.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.rtpData.StateNormal.HeaderColumn.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.rtpData.StateNormal.HeaderColumn.Border.Rounding = 5;
            this.rtpData.StateNormal.HeaderRow.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.rtpData.StateNormal.HeaderRow.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.rtpData.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtpData.StateNormal.HeaderRow.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.rtpData.StateNormal.HeaderRow.Border.Rounding = 5;
            this.rtpData.TabIndex = 109;
            this.rtpData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rtpData_CellContentClick);
            // 
            // vrpt_name
            // 
            this.vrpt_name.HeaderText = "Name";
            this.vrpt_name.MinimumWidth = 6;
            this.vrpt_name.Name = "vrpt_name";
            this.vrpt_name.ReadOnly = true;
            this.vrpt_name.Width = 125;
            // 
            // vrpt_id
            // 
            this.vrpt_id.HeaderText = "Id";
            this.vrpt_id.MinimumWidth = 6;
            this.vrpt_id.Name = "vrpt_id";
            this.vrpt_id.ReadOnly = true;
            this.vrpt_id.Width = 125;
            // 
            // vrpt_title
            // 
            this.vrpt_title.HeaderText = "Title";
            this.vrpt_title.Name = "vrpt_title";
            this.vrpt_title.ReadOnly = true;
            // 
            // lblShow
            // 
            // 
            // 
            // 
            this.lblShow.BackgroundStyle.Class = "";
            this.lblShow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblShow.Image = ((System.Drawing.Image)(resources.GetObject("lblShow.Image")));
            this.lblShow.Location = new System.Drawing.Point(348, 0);
            this.lblShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblShow.Name = "lblShow";
            this.lblShow.SingleLineColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShow.Size = new System.Drawing.Size(367, 35);
            this.lblShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblShow.TabIndex = 110;
            this.lblShow.Text = "Geting Report";
            this.lblShow.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(625, 323);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOk.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOk.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOk.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOk.Palette = this._styleform;
            this.btnOk.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnOk.Size = new System.Drawing.Size(79, 64);
            this.btnOk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.btnOk.StateCommon.Back.ColorAngle = 45F;
            this.btnOk.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnOk.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.StateCommon.Back.Image")));
            this.btnOk.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnOk.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnOk.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.StateCommon.Border.ColorAngle = 50F;
            this.btnOk.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOk.StateCommon.Border.Rounding = 5;
            this.btnOk.StateCommon.Border.Width = 1;
            this.btnOk.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOk.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOk.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOk.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOk.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnOk.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOk.StateNormal.Border.ColorAngle = 45F;
            this.btnOk.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StatePressed.Back.Color1 = System.Drawing.Color.Snow;
            this.btnOk.StatePressed.Back.Color2 = System.Drawing.Color.Snow;
            this.btnOk.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOk.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOk.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOk.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOk.StateTracking.Back.ColorAngle = 45F;
            this.btnOk.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnOk.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnOk.StateTracking.Border.ColorAngle = 45F;
            this.btnOk.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StateTracking.Border.Rounding = 5;
            this.btnOk.TabIndex = 123;
            this.btnOk.Values.Text = "";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtTo
            // 
            this.dtTo.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.dtTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(450, 360);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(169, 31);
            this.dtTo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtTo.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtTo.StateActive.Border.ColorAngle = 10F;
            this.dtTo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtTo.StateActive.Border.Rounding = 10;
            this.dtTo.StateActive.Border.Width = 1;
            this.dtTo.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtTo.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dtTo.StateCommon.Border.Color1 = System.Drawing.Color.MistyRose;
            this.dtTo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtTo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtTo.StateNormal.Border.Rounding = 10;
            this.dtTo.StateNormal.Border.Width = 1;
            this.dtTo.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.StateNormal.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dtTo.TabIndex = 121;
            this.dtTo.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            // 
            // dtFrom
            // 
            this.dtFrom.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.dtFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(450, 320);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(169, 31);
            this.dtFrom.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtFrom.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtFrom.StateActive.Border.ColorAngle = 10F;
            this.dtFrom.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtFrom.StateActive.Border.Rounding = 10;
            this.dtFrom.StateActive.Border.Width = 1;
            this.dtFrom.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtFrom.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dtFrom.StateCommon.Border.Color1 = System.Drawing.Color.MistyRose;
            this.dtFrom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtFrom.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtFrom.StateNormal.Border.Rounding = 10;
            this.dtFrom.StateNormal.Border.Width = 1;
            this.dtFrom.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.StateNormal.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dtFrom.TabIndex = 119;
            this.dtFrom.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            // 
            // cboStock
            // 
            this.cboStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStock.DropDownWidth = 263;
            this.cboStock.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboStock.Location = new System.Drawing.Point(450, 125);
            this.cboStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboStock.MaxDropDownItems = 15;
            this.cboStock.Name = "cboStock";
            this.cboStock.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboStock.Size = new System.Drawing.Size(251, 29);
            this.cboStock.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboStock.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStock.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboStock.StateActive.ComboBox.Border.Rounding = 10;
            this.cboStock.StateActive.ComboBox.Border.Width = 1;
            this.cboStock.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStock.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboStock.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboStock.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStock.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboStock.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboStock.StateCommon.ComboBox.Border.Width = 1;
            this.cboStock.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStock.StateCommon.Item.Border.Rounding = 10;
            this.cboStock.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboStock.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStock.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboStock.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStock.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboStock.StateNormal.ComboBox.Border.Width = 1;
            this.cboStock.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStock.StateNormal.Item.Border.Rounding = 10;
            this.cboStock.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStock.StateTracking.Item.Border.Rounding = 10;
            this.cboStock.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboStock.TabIndex = 113;
            this.cboStock.Text = "Choose System Control";
            // 
            // cboProduct
            // 
            this.cboProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProduct.DropDownWidth = 263;
            this.cboProduct.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboProduct.Location = new System.Drawing.Point(450, 161);
            this.cboProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboProduct.MaxDropDownItems = 15;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboProduct.Size = new System.Drawing.Size(251, 29);
            this.cboProduct.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboProduct.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboProduct.StateActive.ComboBox.Border.Rounding = 10;
            this.cboProduct.StateActive.ComboBox.Border.Width = 1;
            this.cboProduct.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduct.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboProduct.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboProduct.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboProduct.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboProduct.StateCommon.ComboBox.Border.Width = 1;
            this.cboProduct.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateCommon.Item.Border.Rounding = 10;
            this.cboProduct.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboProduct.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduct.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboProduct.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboProduct.StateNormal.ComboBox.Border.Width = 1;
            this.cboProduct.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateNormal.Item.Border.Rounding = 10;
            this.cboProduct.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateTracking.Item.Border.Rounding = 10;
            this.cboProduct.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboProduct.TabIndex = 115;
            this.cboProduct.Text = "Choose System Control";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(354, 278);
            this.labelX11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(81, 37);
            this.labelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX11.TabIndex = 126;
            this.labelX11.Text = "Packing ";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(354, 239);
            this.labelX10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(81, 37);
            this.labelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX10.TabIndex = 125;
            this.labelX10.Text = "Molecule ";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(374, 203);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(61, 37);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX4.TabIndex = 124;
            this.labelX4.Text = "Line ";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboLine
            // 
            this.cboLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLine.DropDownWidth = 263;
            this.cboLine.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboLine.Location = new System.Drawing.Point(450, 207);
            this.cboLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboLine.MaxDropDownItems = 15;
            this.cboLine.Name = "cboLine";
            this.cboLine.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboLine.Size = new System.Drawing.Size(251, 29);
            this.cboLine.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboLine.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLine.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboLine.StateActive.ComboBox.Border.Rounding = 10;
            this.cboLine.StateActive.ComboBox.Border.Width = 1;
            this.cboLine.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLine.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboLine.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboLine.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLine.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboLine.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboLine.StateCommon.ComboBox.Border.Width = 1;
            this.cboLine.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLine.StateCommon.Item.Border.Rounding = 10;
            this.cboLine.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboLine.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLine.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboLine.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLine.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboLine.StateNormal.ComboBox.Border.Width = 1;
            this.cboLine.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLine.StateNormal.Item.Border.Rounding = 10;
            this.cboLine.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLine.StateTracking.Item.Border.Rounding = 10;
            this.cboLine.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboLine.TabIndex = 115;
            this.cboLine.Text = "Choose System Control";
            // 
            // cboMolecule
            // 
            this.cboMolecule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMolecule.DropDownWidth = 263;
            this.cboMolecule.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboMolecule.Location = new System.Drawing.Point(450, 243);
            this.cboMolecule.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboMolecule.MaxDropDownItems = 15;
            this.cboMolecule.Name = "cboMolecule";
            this.cboMolecule.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboMolecule.Size = new System.Drawing.Size(251, 29);
            this.cboMolecule.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboMolecule.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboMolecule.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboMolecule.StateActive.ComboBox.Border.Rounding = 10;
            this.cboMolecule.StateActive.ComboBox.Border.Width = 1;
            this.cboMolecule.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMolecule.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboMolecule.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboMolecule.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboMolecule.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboMolecule.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboMolecule.StateCommon.ComboBox.Border.Width = 1;
            this.cboMolecule.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboMolecule.StateCommon.Item.Border.Rounding = 10;
            this.cboMolecule.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboMolecule.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMolecule.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboMolecule.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboMolecule.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboMolecule.StateNormal.ComboBox.Border.Width = 1;
            this.cboMolecule.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboMolecule.StateNormal.Item.Border.Rounding = 10;
            this.cboMolecule.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboMolecule.StateTracking.Item.Border.Rounding = 10;
            this.cboMolecule.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboMolecule.TabIndex = 115;
            this.cboMolecule.Text = "Choose System Control";
            // 
            // cboPacking
            // 
            this.cboPacking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPacking.DropDownWidth = 263;
            this.cboPacking.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboPacking.Location = new System.Drawing.Point(450, 282);
            this.cboPacking.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboPacking.MaxDropDownItems = 15;
            this.cboPacking.Name = "cboPacking";
            this.cboPacking.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboPacking.Size = new System.Drawing.Size(251, 29);
            this.cboPacking.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboPacking.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboPacking.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboPacking.StateActive.ComboBox.Border.Rounding = 10;
            this.cboPacking.StateActive.ComboBox.Border.Width = 1;
            this.cboPacking.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacking.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboPacking.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboPacking.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboPacking.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboPacking.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboPacking.StateCommon.ComboBox.Border.Width = 1;
            this.cboPacking.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboPacking.StateCommon.Item.Border.Rounding = 10;
            this.cboPacking.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboPacking.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacking.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboPacking.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboPacking.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboPacking.StateNormal.ComboBox.Border.Width = 1;
            this.cboPacking.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboPacking.StateNormal.Item.Border.Rounding = 10;
            this.cboPacking.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboPacking.StateTracking.Item.Border.Rounding = 10;
            this.cboPacking.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboPacking.TabIndex = 115;
            this.cboPacking.Text = "Choose System Control";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(354, 53);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 37);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.TabIndex = 127;
            this.labelX1.Text = "Customer ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboCustomer
            // 
            this.cboCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCustomer.DropDownWidth = 263;
            this.cboCustomer.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboCustomer.Location = new System.Drawing.Point(450, 57);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCustomer.MaxDropDownItems = 15;
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cboCustomer.Size = new System.Drawing.Size(251, 29);
            this.cboCustomer.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboCustomer.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboCustomer.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboCustomer.StateActive.ComboBox.Border.Rounding = 10;
            this.cboCustomer.StateActive.ComboBox.Border.Width = 1;
            this.cboCustomer.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboCustomer.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboCustomer.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboCustomer.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboCustomer.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboCustomer.StateCommon.ComboBox.Border.Width = 1;
            this.cboCustomer.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboCustomer.StateCommon.Item.Border.Rounding = 10;
            this.cboCustomer.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboCustomer.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboCustomer.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboCustomer.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboCustomer.StateNormal.ComboBox.Border.Width = 1;
            this.cboCustomer.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboCustomer.StateNormal.Item.Border.Rounding = 10;
            this.cboCustomer.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboCustomer.StateTracking.Item.Border.Rounding = 10;
            this.cboCustomer.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboCustomer.TabIndex = 114;
            this.cboCustomer.Text = "Choose System Control";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(354, 121);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(81, 37);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 127;
            this.labelX2.Text = "Stock ";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(354, 157);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(81, 37);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX3.TabIndex = 127;
            this.labelX3.Text = "Product";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(354, 317);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(81, 37);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX5.TabIndex = 126;
            this.labelX5.Text = "Date From";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(354, 357);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(81, 37);
            this.labelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX6.TabIndex = 126;
            this.labelX6.Text = "Date To";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(354, 88);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(81, 37);
            this.labelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX7.TabIndex = 129;
            this.labelX7.Text = "Supplies";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbosupply
            // 
            this.cbosupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosupply.DropDownWidth = 263;
            this.cbosupply.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbosupply.Location = new System.Drawing.Point(450, 92);
            this.cbosupply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbosupply.MaxDropDownItems = 15;
            this.cbosupply.Name = "cbosupply";
            this.cbosupply.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbosupply.Size = new System.Drawing.Size(251, 29);
            this.cbosupply.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cbosupply.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupply.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbosupply.StateActive.ComboBox.Border.Rounding = 10;
            this.cbosupply.StateActive.ComboBox.Border.Width = 1;
            this.cbosupply.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosupply.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbosupply.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbosupply.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupply.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbosupply.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbosupply.StateCommon.ComboBox.Border.Width = 1;
            this.cbosupply.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupply.StateCommon.Item.Border.Rounding = 10;
            this.cbosupply.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbosupply.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosupply.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbosupply.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupply.StateNormal.ComboBox.Border.Rounding = 10;
            this.cbosupply.StateNormal.ComboBox.Border.Width = 1;
            this.cbosupply.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupply.StateNormal.Item.Border.Rounding = 10;
            this.cbosupply.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbosupply.StateTracking.Item.Border.Rounding = 10;
            this.cbosupply.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbosupply.TabIndex = 128;
            this.cbosupply.Text = "Choose System Control";
            // 
            // progressbarsetup
            // 
            this.progressbarsetup.AllowAnimations = false;
            this.progressbarsetup.Animation = 0;
            this.progressbarsetup.AnimationSpeed = 220;
            this.progressbarsetup.AnimationStep = 10;
            this.progressbarsetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbarsetup.BackgroundImage")));
            this.progressbarsetup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.BorderRadius = 10;
            this.progressbarsetup.BorderThickness = 1;
            this.progressbarsetup.Location = new System.Drawing.Point(339, 745);
            this.progressbarsetup.Maximum = 100;
            this.progressbarsetup.MaximumValue = 100;
            this.progressbarsetup.Minimum = 0;
            this.progressbarsetup.MinimumValue = 0;
            this.progressbarsetup.Name = "progressbarsetup";
            this.progressbarsetup.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressbarsetup.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressbarsetup.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressbarsetup.ProgressColorRight = System.Drawing.Color.Magenta;
            this.progressbarsetup.Size = new System.Drawing.Size(362, 10);
            this.progressbarsetup.TabIndex = 130;
            this.progressbarsetup.Value = 10;
            this.progressbarsetup.ValueByTransition = 10;
            this.progressbarsetup.Visible = false;
            // 
            // FrmRepots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(716, 767);
            this.Controls.Add(this.progressbarsetup);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cbosupply);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.cboPacking);
            this.Controls.Add(this.cboMolecule);
            this.Controls.Add(this.cboLine);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboStock);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.rtpData);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRepots";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRepots";
            this.Load += new System.EventHandler(this.FrmRepots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtpData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMolecule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosupply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView rtpData;
        private DevComponents.DotNetBar.LabelX lblShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrpt_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrpt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrpt_title;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtTo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboStock;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboProduct;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboLine;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboMolecule;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboPacking;
        private DevComponents.DotNetBar.LabelX labelX1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboCustomer;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbosupply;
        private Bunifu.UI.WinForms.BunifuProgressBar progressbarsetup;
    }
}