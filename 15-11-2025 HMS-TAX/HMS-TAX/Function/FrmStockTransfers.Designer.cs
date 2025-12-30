namespace HMS_TAX.Function
{
    partial class FrmStockTransfers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockTransfers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._menu_short = new System.Windows.Forms.MenuStrip();
            this.Function = new System.Windows.Forms.ToolStripMenuItem();
            this._clear = new System.Windows.Forms.ToolStripMenuItem();
            this._AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this._draft = new System.Windows.Forms.ToolStripMenuItem();
            this._Commit = new System.Windows.Forms.ToolStripMenuItem();
            this._exit = new System.Windows.Forms.ToolStripMenuItem();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this._gTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cboBatchId = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboProduct = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboStockTo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cboStockFrom = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.dgPos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSysDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vst_code_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vst_code_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vstockFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vstockTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbatch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MenuFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._POS_merch_batch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._POS_delete = new System.Windows.Forms.ToolStripMenuItem();
            this._menu_short.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gTop)).BeginInit();
            this._gTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBatchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).BeginInit();
            this._MenuFunction.SuspendLayout();
            this.SuspendLayout();
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
            this._menu_short.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this._menu_short.Size = new System.Drawing.Size(963, 25);
            this._menu_short.TabIndex = 116;
            this._menu_short.Text = "menuStrip1";
            this._menu_short.Visible = false;
            // 
            // Function
            // 
            this.Function.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clear,
            this._AddNew,
            this._draft,
            this._Commit,
            this._exit});
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(66, 19);
            this.Function.Text = "Function";
            // 
            // _clear
            // 
            this._clear.Name = "_clear";
            this._clear.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._clear.Size = new System.Drawing.Size(160, 22);
            this._clear.Text = "Clear";
            // 
            // _AddNew
            // 
            this._AddNew.Name = "_AddNew";
            this._AddNew.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._AddNew.Size = new System.Drawing.Size(160, 22);
            this._AddNew.Text = "Add Product";
            this._AddNew.Click += new System.EventHandler(this._AddNew_Click);
            // 
            // _draft
            // 
            this._draft.Name = "_draft";
            this._draft.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this._draft.Size = new System.Drawing.Size(160, 22);
            this._draft.Text = "Draft";
            // 
            // _Commit
            // 
            this._Commit.Name = "_Commit";
            this._Commit.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this._Commit.Size = new System.Drawing.Size(160, 22);
            this._Commit.Text = "Commit";
            this._Commit.Click += new System.EventHandler(this._POS_Click);
            // 
            // _exit
            // 
            this._exit.Name = "_exit";
            this._exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this._exit.Size = new System.Drawing.Size(160, 22);
            this._exit.Text = "Exit";
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
            // _gTop
            // 
            this._gTop.Controls.Add(this.cboBatchId);
            this._gTop.Controls.Add(this.cboProduct);
            this._gTop.Controls.Add(this.cboStockTo);
            this._gTop.Controls.Add(this.cboStockFrom);
            this._gTop.Controls.Add(this.labelX4);
            this._gTop.Controls.Add(this.txtId);
            this._gTop.Controls.Add(this.labelX3);
            this._gTop.Controls.Add(this.labelX2);
            this._gTop.Controls.Add(this.labelX1);
            this._gTop.Controls.Add(this.kryptonWrapLabel1);
            this._gTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._gTop.Location = new System.Drawing.Point(0, 0);
            this._gTop.Margin = new System.Windows.Forms.Padding(4);
            this._gTop.Name = "_gTop";
            this._gTop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this._gTop.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowSheet;
            this._gTop.Size = new System.Drawing.Size(963, 116);
            this._gTop.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._gTop.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._gTop.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._gTop.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._gTop.TabIndex = 117;
            // 
            // cboBatchId
            // 
            this.cboBatchId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBatchId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBatchId.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.cboBatchId.DropDownWidth = 263;
            this.cboBatchId.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboBatchId.Location = new System.Drawing.Point(586, 65);
            this.cboBatchId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboBatchId.MaxDropDownItems = 15;
            this.cboBatchId.Name = "cboBatchId";
            this.cboBatchId.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.cboBatchId.Size = new System.Drawing.Size(253, 30);
            this.cboBatchId.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboBatchId.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBatchId.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboBatchId.StateActive.ComboBox.Border.Rounding = 10;
            this.cboBatchId.StateActive.ComboBox.Border.Width = 1;
            this.cboBatchId.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cboBatchId.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboBatchId.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboBatchId.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboBatchId.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBatchId.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboBatchId.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboBatchId.StateCommon.ComboBox.Border.Width = 1;
            this.cboBatchId.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboBatchId.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboBatchId.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBatchId.StateCommon.Item.Border.Rounding = 10;
            this.cboBatchId.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cboBatchId.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboBatchId.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboBatchId.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBatchId.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboBatchId.StateNormal.ComboBox.Border.Width = 1;
            this.cboBatchId.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBatchId.StateNormal.Item.Border.Rounding = 10;
            this.cboBatchId.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cboBatchId.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboBatchId.StateTracking.Item.Border.Rounding = 10;
            this.cboBatchId.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboBatchId.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatchId.TabIndex = 115;
            this.cboBatchId.Text = "Select batch";
            // 
            // cboProduct
            // 
            this.cboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProduct.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.cboProduct.DropDownWidth = 263;
            this.cboProduct.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboProduct.Location = new System.Drawing.Point(586, 27);
            this.cboProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboProduct.MaxDropDownItems = 15;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.cboProduct.Size = new System.Drawing.Size(253, 30);
            this.cboProduct.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboProduct.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboProduct.StateActive.ComboBox.Border.Rounding = 10;
            this.cboProduct.StateActive.ComboBox.Border.Width = 1;
            this.cboProduct.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cboProduct.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboProduct.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboProduct.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboProduct.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboProduct.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboProduct.StateCommon.ComboBox.Border.Width = 1;
            this.cboProduct.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboProduct.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cboProduct.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateCommon.Item.Border.Rounding = 10;
            this.cboProduct.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cboProduct.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
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
            this.cboProduct.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cboProduct.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboProduct.StateTracking.Item.Border.Rounding = 10;
            this.cboProduct.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboProduct.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduct.TabIndex = 115;
            this.cboProduct.Text = "Select product";
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // cboStockTo
            // 
            this.cboStockTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStockTo.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCustom1;
            this.cboStockTo.DropDownWidth = 263;
            this.cboStockTo.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboStockTo.Location = new System.Drawing.Point(289, 66);
            this.cboStockTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboStockTo.MaxDropDownItems = 15;
            this.cboStockTo.Name = "cboStockTo";
            this.cboStockTo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.cboStockTo.Size = new System.Drawing.Size(191, 29);
            this.cboStockTo.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboStockTo.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockTo.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboStockTo.StateActive.ComboBox.Border.Rounding = 10;
            this.cboStockTo.StateActive.ComboBox.Border.Width = 1;
            this.cboStockTo.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStockTo.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboStockTo.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboStockTo.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockTo.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboStockTo.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboStockTo.StateCommon.ComboBox.Border.Width = 1;
            this.cboStockTo.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockTo.StateCommon.Item.Border.Rounding = 10;
            this.cboStockTo.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboStockTo.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStockTo.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboStockTo.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockTo.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboStockTo.StateNormal.ComboBox.Border.Width = 1;
            this.cboStockTo.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockTo.StateNormal.Item.Border.Rounding = 10;
            this.cboStockTo.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockTo.StateTracking.Item.Border.Rounding = 10;
            this.cboStockTo.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboStockTo.TabIndex = 115;
            this.cboStockTo.Text = "Choose System Control";
            // 
            // cboStockFrom
            // 
            this.cboStockFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.cboStockFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStockFrom.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonCustom1;
            this.cboStockFrom.DropDownWidth = 263;
            this.cboStockFrom.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cboStockFrom.Location = new System.Drawing.Point(93, 66);
            this.cboStockFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboStockFrom.MaxDropDownItems = 15;
            this.cboStockFrom.Name = "cboStockFrom";
            this.cboStockFrom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.cboStockFrom.Size = new System.Drawing.Size(191, 29);
            this.cboStockFrom.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboStockFrom.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockFrom.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboStockFrom.StateActive.ComboBox.Border.Rounding = 10;
            this.cboStockFrom.StateActive.ComboBox.Border.Width = 1;
            this.cboStockFrom.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStockFrom.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboStockFrom.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboStockFrom.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockFrom.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboStockFrom.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboStockFrom.StateCommon.ComboBox.Border.Width = 1;
            this.cboStockFrom.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockFrom.StateCommon.Item.Border.Rounding = 10;
            this.cboStockFrom.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cboStockFrom.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStockFrom.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboStockFrom.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockFrom.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboStockFrom.StateNormal.ComboBox.Border.Width = 1;
            this.cboStockFrom.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockFrom.StateNormal.Item.Border.Rounding = 10;
            this.cboStockFrom.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboStockFrom.StateTracking.Item.Border.Rounding = 10;
            this.cboStockFrom.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboStockFrom.TabIndex = 114;
            this.cboStockFrom.Text = "Choose System Control";
            this.cboStockFrom.SelectedIndexChanged += new System.EventHandler(this.cboStockFrom_SelectedIndexChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.UniqueName = "72824B0CDBCF4439AB928735060DE679";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(481, 62);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 37);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX4.TabIndex = 104;
            this.labelX4.Text = "Batch :";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.Border.Class = "TextBoxBorder";
            this.txtId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtId.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtId.Location = new System.Drawing.Point(93, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(387, 29);
            this.txtId.TabIndex = 105;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtId.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtId.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtId.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtId.WatermarkImage")));
            this.txtId.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtId.WatermarkText = "លេខសម្គាល់ថ្មី";
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(481, 24);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 37);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX3.TabIndex = 104;
            this.labelX3.Text = "Product :";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(17, 62);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 37);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 104;
            this.labelX2.Text = "Stock :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(17, 24);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 37);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.TabIndex = 104;
            this.labelX1.Text = "ID :";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonWrapLabel1.Image")));
            this.kryptonWrapLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(49, 5);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(358, 13);
            this.kryptonWrapLabel1.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.kryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonWrapLabel1.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonWrapLabel1.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateNormal.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonWrapLabel1.StateNormal.TextColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Text = "        F1 : Clear  ,F3 : Add product  , F5 : Draft List  ,F7 : Commit";
            // 
            // dgPos
            // 
            this.dgPos.AllowUserToAddRows = false;
            this.dgPos.AllowUserToDeleteRows = false;
            this.dgPos.AllowUserToResizeColumns = false;
            this.dgPos.AllowUserToResizeRows = false;
            this.dgPos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNum,
            this.vSysDocNum,
            this.vpro_id,
            this.vst_code_from,
            this.vst_code_to,
            this.vName,
            this.vstockFrom,
            this.vstockTo,
            this.vqty,
            this.vbatch_id});
            this.dgPos.ContextMenuStrip = this._MenuFunction;
            this.dgPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPos.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgPos.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgPos.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgPos.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgPos.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgPos.Location = new System.Drawing.Point(0, 116);
            this.dgPos.Margin = new System.Windows.Forms.Padding(4);
            this.dgPos.MultiSelect = false;
            this.dgPos.Name = "dgPos";
            this.dgPos.RowHeadersVisible = false;
            this.dgPos.RowHeadersWidth = 51;
            this.dgPos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPos.Size = new System.Drawing.Size(963, 470);
            this.dgPos.StateCommon.Background.Color1 = System.Drawing.Color.MistyRose;
            this.dgPos.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgPos.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.dgPos.StateCommon.Background.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.dgPos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgPos.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgPos.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgPos.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgPos.StateCommon.HeaderColumn.Border.Rounding = 5;
            this.dgPos.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DarkBlue;
            this.dgPos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dgPos.StateCommon.HeaderRow.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgPos.StateCommon.HeaderRow.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.dgPos.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPos.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgPos.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgPos.StateNormal.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dgPos.StateNormal.HeaderColumn.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.dgPos.StateNormal.HeaderColumn.Border.Rounding = 5;
            this.dgPos.StateNormal.HeaderRow.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.dgPos.StateNormal.HeaderRow.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.dgPos.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgPos.StateNormal.HeaderRow.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgPos.StateNormal.HeaderRow.Border.Rounding = 5;
            this.dgPos.TabIndex = 118;
            this.dgPos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellContentClick);
            this.dgPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellContentClick);
            this.dgPos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellContentClick);
            this.dgPos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellEndEdit);
            // 
            // vNum
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.vNum.HeaderText = "No";
            this.vNum.MinimumWidth = 6;
            this.vNum.Name = "vNum";
            // 
            // vSysDocNum
            // 
            this.vSysDocNum.HeaderText = "sysdocnum";
            this.vSysDocNum.Name = "vSysDocNum";
            // 
            // vpro_id
            // 
            this.vpro_id.HeaderText = "pro_code";
            this.vpro_id.Name = "vpro_id";
            // 
            // vst_code_from
            // 
            this.vst_code_from.HeaderText = "vst_code_from";
            this.vst_code_from.Name = "vst_code_from";
            // 
            // vst_code_to
            // 
            this.vst_code_to.HeaderText = "vst_code_to";
            this.vst_code_to.Name = "vst_code_to";
            // 
            // vName
            // 
            this.vName.HeaderText = "Items";
            this.vName.MinimumWidth = 6;
            this.vName.Name = "vName";
            // 
            // vstockFrom
            // 
            this.vstockFrom.HeaderText = "Stock From";
            this.vstockFrom.Name = "vstockFrom";
            // 
            // vstockTo
            // 
            this.vstockTo.HeaderText = "Stock To";
            this.vstockTo.Name = "vstockTo";
            // 
            // vqty
            // 
            this.vqty.HeaderText = "Qty";
            this.vqty.Name = "vqty";
            // 
            // vbatch_id
            // 
            this.vbatch_id.HeaderText = "Batch iD";
            this.vbatch_id.Name = "vbatch_id";
            // 
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._POS_merch_batch,
            this.toolStripSeparator2,
            this._POS_delete});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(187, 54);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _POS_merch_batch
            // 
            this._POS_merch_batch.Image = ((System.Drawing.Image)(resources.GetObject("_POS_merch_batch.Image")));
            this._POS_merch_batch.Name = "_POS_merch_batch";
            this._POS_merch_batch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this._POS_merch_batch.Size = new System.Drawing.Size(186, 22);
            this._POS_merch_batch.Text = "Merch Batch";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // _POS_delete
            // 
            this._POS_delete.Image = ((System.Drawing.Image)(resources.GetObject("_POS_delete.Image")));
            this._POS_delete.Name = "_POS_delete";
            this._POS_delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._POS_delete.Size = new System.Drawing.Size(186, 22);
            this._POS_delete.Text = "Delete";
            this._POS_delete.Click += new System.EventHandler(this._POS_delete_Click);
            // 
            // FrmStockTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(963, 586);
            this.Controls.Add(this.dgPos);
            this.Controls.Add(this._gTop);
            this.Controls.Add(this._menu_short);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockTransfers";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateActive.Header.Border.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateInactive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateInactive.Back.Color2 = System.Drawing.Color.White;
            this.StateInactive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateInactive.Border.Color2 = System.Drawing.Color.White;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateInactive.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateInactive.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateInactive.Header.Border.Color2 = System.Drawing.Color.White;
            this.StateInactive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateInactive.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "FrmStockTransfers";
            this.Load += new System.EventHandler(this.FrmStockTransfers_Load);
            this.Shown += new System.EventHandler(this.FrmStockTransfers_Shown);
            this._menu_short.ResumeLayout(false);
            this._menu_short.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gTop)).EndInit();
            this._gTop.ResumeLayout(false);
            this._gTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBatchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).EndInit();
            this._MenuFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip _menu_short;
        private System.Windows.Forms.ToolStripMenuItem Function;
        private System.Windows.Forms.ToolStripMenuItem _clear;
        private System.Windows.Forms.ToolStripMenuItem _AddNew;
        private System.Windows.Forms.ToolStripMenuItem _draft;
        private System.Windows.Forms.ToolStripMenuItem _Commit;
        private System.Windows.Forms.ToolStripMenuItem _exit;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel _gTop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtId;
        private DevComponents.DotNetBar.LabelX labelX1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgPos;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboStockFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboStockTo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboBatchId;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _POS_merch_batch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _POS_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSysDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vst_code_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn vst_code_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vstockFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn vstockTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatch_id;
    }
}