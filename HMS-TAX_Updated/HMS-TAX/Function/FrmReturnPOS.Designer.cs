namespace HMS_TAX.Function
{
    partial class FrmReturnPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnPOS));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this._gTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbltotal = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.txtInvoiceReturn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtInvoice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtInfo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this._menu_short = new System.Windows.Forms.MenuStrip();
            this.Function = new System.Windows.Forms.ToolStripMenuItem();
            this._clear = new System.Windows.Forms.ToolStripMenuItem();
            this._Customer = new System.Windows.Forms.ToolStripMenuItem();
            this._AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this._draft = new System.Windows.Forms.ToolStripMenuItem();
            this._invoice = new System.Windows.Forms.ToolStripMenuItem();
            this._POS = new System.Windows.Forms.ToolStripMenuItem();
            this._exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgPos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSysDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsto_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbatch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MenuFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._POS_delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._gTop)).BeginInit();
            this._gTop.SuspendLayout();
            this._menu_short.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).BeginInit();
            this._MenuFunction.SuspendLayout();
            this.SuspendLayout();
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
            this._gTop.Controls.Add(this.lbltotal);
            this._gTop.Controls.Add(this.txtInvoiceReturn);
            this._gTop.Controls.Add(this.labelX3);
            this._gTop.Controls.Add(this.txtInvoice);
            this._gTop.Controls.Add(this.labelX1);
            this._gTop.Controls.Add(this.labelX4);
            this._gTop.Controls.Add(this.labelX2);
            this._gTop.Controls.Add(this.txtInfo);
            this._gTop.Controls.Add(this.txtName);
            this._gTop.Controls.Add(this.kryptonWrapLabel1);
            this._gTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._gTop.Location = new System.Drawing.Point(0, 24);
            this._gTop.Margin = new System.Windows.Forms.Padding(4);
            this._gTop.Name = "_gTop";
            this._gTop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this._gTop.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this._gTop.Size = new System.Drawing.Size(984, 121);
            this._gTop.TabIndex = 2;
            // 
            // lbltotal
            // 
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Red;
            this.lbltotal.Image = ((System.Drawing.Image)(resources.GetObject("lbltotal.Image")));
            this.lbltotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbltotal.Location = new System.Drawing.Point(469, 93);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Palette = this._styleform;
            this.lbltotal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lbltotal.Size = new System.Drawing.Size(82, 16);
            this.lbltotal.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbltotal.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.lbltotal.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbltotal.StateNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.SystemDefault;
            this.lbltotal.StateNormal.TextColor = System.Drawing.Color.Red;
            this.lbltotal.Text = "         Total =0";
            this.lbltotal.UseWaitCursor = true;
            // 
            // txtInvoiceReturn
            // 
            // 
            // 
            // 
            this.txtInvoiceReturn.Border.Class = "TextBoxBorder";
            this.txtInvoiceReturn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvoiceReturn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtInvoiceReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInvoiceReturn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtInvoiceReturn.Location = new System.Drawing.Point(109, 61);
            this.txtInvoiceReturn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtInvoiceReturn.Name = "txtInvoiceReturn";
            this.txtInvoiceReturn.Size = new System.Drawing.Size(322, 29);
            this.txtInvoiceReturn.TabIndex = 1;
            this.txtInvoiceReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoiceReturn.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtInvoiceReturn.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtInvoiceReturn.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtInvoiceReturn.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtInvoiceReturn.WatermarkImage")));
            this.txtInvoiceReturn.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtInvoiceReturn.WatermarkText = "លេខវិក័យប័ត្រ ត្រលប់ចូលវិញ";
            this.txtInvoiceReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceReturn_KeyDown);
            this.txtInvoiceReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceReturn_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(8, 57);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(97, 37);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX3.TabIndex = 104;
            this.labelX3.Text = "Re-Invoice :";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtInvoice
            // 
            // 
            // 
            // 
            this.txtInvoice.Border.Class = "TextBoxBorder";
            this.txtInvoice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvoice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInvoice.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtInvoice.Location = new System.Drawing.Point(109, 27);
            this.txtInvoice.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(322, 29);
            this.txtInvoice.TabIndex = 0;
            this.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoice.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtInvoice.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtInvoice.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtInvoice.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtInvoice.WatermarkImage")));
            this.txtInvoice.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtInvoice.WatermarkText = "លេខសម្គាល់ថ្មី";
            this.txtInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoice_KeyPress);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(8, 23);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 37);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.TabIndex = 104;
            this.labelX1.Text = "Invoice :";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(459, 57);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 37);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX4.TabIndex = 104;
            this.labelX4.Text = "Info :";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(459, 23);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 37);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 104;
            this.labelX2.Text = "Customer :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtInfo
            // 
            // 
            // 
            // 
            this.txtInfo.Border.Class = "TextBoxBorder";
            this.txtInfo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInfo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtInfo.Location = new System.Drawing.Point(557, 62);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(322, 26);
            this.txtInfo.TabIndex = 103;
            this.txtInfo.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtInfo.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtInfo.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtInfo.WatermarkText = "ព៌តមានផ្សេងៗ";
            this.txtInfo.WordWrap = false;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(557, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 26);
            this.txtName.TabIndex = 103;
            this.txtName.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtName.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtName.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtName.WatermarkText = "ឈ្នោះ អតិថិជន";
            this.txtName.WordWrap = false;
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonWrapLabel1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonWrapLabel1.Image")));
            this.kryptonWrapLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(112, 7);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(342, 15);
            this.kryptonWrapLabel1.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.kryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonWrapLabel1.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonWrapLabel1.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonWrapLabel1.StateNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonWrapLabel1.Text = "        F1 : Clear  ,F3 : Add product  , F5 : Draft List  ,F7 : Commit";
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
            this._menu_short.Size = new System.Drawing.Size(984, 24);
            this._menu_short.TabIndex = 115;
            this._menu_short.Text = "menuStrip1";
            this._menu_short.Visible = false;
            // 
            // Function
            // 
            this.Function.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clear,
            this._Customer,
            this._AddNew,
            this._draft,
            this._invoice,
            this._POS,
            this._exit});
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(66, 20);
            this.Function.Text = "Function";
            // 
            // _clear
            // 
            this._clear.Name = "_clear";
            this._clear.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._clear.Size = new System.Drawing.Size(183, 22);
            this._clear.Text = "Clear";
            this._clear.Click += new System.EventHandler(this._clear_Click);
            // 
            // _Customer
            // 
            this._Customer.Name = "_Customer";
            this._Customer.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this._Customer.Size = new System.Drawing.Size(183, 22);
            this._Customer.Text = "Search Customer";
            // 
            // _AddNew
            // 
            this._AddNew.Name = "_AddNew";
            this._AddNew.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._AddNew.Size = new System.Drawing.Size(183, 22);
            this._AddNew.Text = "Add Product";
            // 
            // _draft
            // 
            this._draft.Name = "_draft";
            this._draft.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this._draft.Size = new System.Drawing.Size(183, 22);
            this._draft.Text = "Draft";
            this._draft.Click += new System.EventHandler(this._draft_Click);
            // 
            // _invoice
            // 
            this._invoice.Name = "_invoice";
            this._invoice.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this._invoice.Size = new System.Drawing.Size(183, 22);
            this._invoice.Text = "Invoice";
            this._invoice.Click += new System.EventHandler(this._invoice_Click);
            // 
            // _POS
            // 
            this._POS.Name = "_POS";
            this._POS.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this._POS.Size = new System.Drawing.Size(183, 22);
            this._POS.Text = "POS";
            this._POS.Click += new System.EventHandler(this._POS_Click);
            // 
            // _exit
            // 
            this._exit.Name = "_exit";
            this._exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this._exit.Size = new System.Drawing.Size(183, 22);
            this._exit.Text = "Exit";
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
            this.vName,
            this.vpro_id,
            this.vsto_id,
            this.vprice,
            this.vqty,
            this.vdiscount,
            this.vamount,
            this.vbatch_id});
            this.dgPos.ContextMenuStrip = this._MenuFunction;
            this.dgPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPos.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgPos.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgPos.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgPos.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgPos.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgPos.Location = new System.Drawing.Point(0, 145);
            this.dgPos.Margin = new System.Windows.Forms.Padding(4);
            this.dgPos.MultiSelect = false;
            this.dgPos.Name = "dgPos";
            this.dgPos.RowHeadersVisible = false;
            this.dgPos.RowHeadersWidth = 51;
            this.dgPos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPos.Size = new System.Drawing.Size(984, 416);
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
            this.dgPos.TabIndex = 1;
            this.dgPos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellContentClick);
            this.dgPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellContentClick);
            this.dgPos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellEndEdit);
            this.dgPos.Click += new System.EventHandler(this.dgPos_Click);
            // 
            // vNum
            // 
            this.vNum.HeaderText = "No";
            this.vNum.MinimumWidth = 6;
            this.vNum.Name = "vNum";
            // 
            // vSysDocNum
            // 
            this.vSysDocNum.HeaderText = "sysdocnum";
            this.vSysDocNum.Name = "vSysDocNum";
            // 
            // vName
            // 
            this.vName.HeaderText = "Items";
            this.vName.MinimumWidth = 6;
            this.vName.Name = "vName";
            // 
            // vpro_id
            // 
            this.vpro_id.HeaderText = "Pro_id";
            this.vpro_id.Name = "vpro_id";
            // 
            // vsto_id
            // 
            this.vsto_id.HeaderText = "Stock";
            this.vsto_id.Name = "vsto_id";
            this.vsto_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vsto_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._POS_delete});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(150, 26);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _POS_delete
            // 
            this._POS_delete.Image = ((System.Drawing.Image)(resources.GetObject("_POS_delete.Image")));
            this._POS_delete.Name = "_POS_delete";
            this._POS_delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._POS_delete.Size = new System.Drawing.Size(149, 22);
            this._POS_delete.Text = "Delete";
            this._POS_delete.Click += new System.EventHandler(this._POS_delete_Click);
            // 
            // FrmReturnPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgPos);
            this.Controls.Add(this._gTop);
            this.Controls.Add(this._menu_short);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReturnPOS";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FrmReturnPOS_Load);
            this.Shown += new System.EventHandler(this.FrmReturnPOS_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._gTop)).EndInit();
            this._gTop.ResumeLayout(false);
            this._gTop.PerformLayout();
            this._menu_short.ResumeLayout(false);
            this._menu_short.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).EndInit();
            this._MenuFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel _gTop;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoice;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvoiceReturn;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInfo;
        private System.Windows.Forms.MenuStrip _menu_short;
        private System.Windows.Forms.ToolStripMenuItem Function;
        private System.Windows.Forms.ToolStripMenuItem _clear;
        private System.Windows.Forms.ToolStripMenuItem _Customer;
        private System.Windows.Forms.ToolStripMenuItem _AddNew;
        private System.Windows.Forms.ToolStripMenuItem _draft;
        private System.Windows.Forms.ToolStripMenuItem _invoice;
        private System.Windows.Forms.ToolStripMenuItem _POS;
        private System.Windows.Forms.ToolStripMenuItem _exit;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSysDocNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpro_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn vsto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn vqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatch_id;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _POS_delete;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lbltotal;
    }
}