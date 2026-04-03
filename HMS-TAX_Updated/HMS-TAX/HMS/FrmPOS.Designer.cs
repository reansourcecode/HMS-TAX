namespace HMS_TAX.HMS
{
    partial class FrmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this._gTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblRunning = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lbltotal = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lblRate = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbocustomer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtinvoice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cboproduct = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
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
            this._POS_add_batch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._POS_merch_batch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._POS_delete = new System.Windows.Forms.ToolStripMenuItem();
            this._menu_short = new System.Windows.Forms.MenuStrip();
            this.Function = new System.Windows.Forms.ToolStripMenuItem();
            this._clear = new System.Windows.Forms.ToolStripMenuItem();
            this._Customer = new System.Windows.Forms.ToolStripMenuItem();
            this._AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this._draft = new System.Windows.Forms.ToolStripMenuItem();
            this._POS = new System.Windows.Forms.ToolStripMenuItem();
            this._exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._gTop)).BeginInit();
            this._gTop.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbocustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).BeginInit();
            this._MenuFunction.SuspendLayout();
            this._menu_short.SuspendLayout();
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
            this._gTop.Controls.Add(this.groupPanel1);
            this._gTop.Controls.Add(this.kryptonLabel5);
            this._gTop.Controls.Add(this.kryptonWrapLabel1);
            this._gTop.Controls.Add(this.kryptonLabel2);
            this._gTop.Controls.Add(this.cbocustomer);
            this._gTop.Controls.Add(this.kryptonLabel1);
            this._gTop.Controls.Add(this.txtinvoice);
            this._gTop.Controls.Add(this.cboproduct);
            this._gTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._gTop.Location = new System.Drawing.Point(0, 0);
            this._gTop.Margin = new System.Windows.Forms.Padding(4);
            this._gTop.Name = "_gTop";
            this._gTop.Palette = this._styleform;
            this._gTop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this._gTop.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this._gTop.Size = new System.Drawing.Size(1145, 137);
            this._gTop.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.groupPanel1.Controls.Add(this.lblRunning);
            this.groupPanel1.Controls.Add(this.lbltotal);
            this.groupPanel1.Controls.Add(this.lblRate);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(931, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(211, 125);
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
            this.groupPanel1.TabIndex = 101;
            // 
            // lblRunning
            // 
            this.lblRunning.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRunning.Image = ((System.Drawing.Image)(resources.GetObject("lblRunning.Image")));
            this.lblRunning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRunning.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblRunning.Location = new System.Drawing.Point(8, 73);
            this.lblRunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Palette = this._styleform;
            this.lblRunning.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblRunning.Size = new System.Drawing.Size(49, 17);
            this.lblRunning.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.lblRunning.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRunning.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.lblRunning.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRunning.StateNormal.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.lblRunning.StateNormal.TextColor = System.Drawing.Color.Red;
            this.lblRunning.Text = "      TI";
            // 
            // lbltotal
            // 
            this.lbltotal.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Red;
            this.lbltotal.Image = ((System.Drawing.Image)(resources.GetObject("lbltotal.Image")));
            this.lbltotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbltotal.Location = new System.Drawing.Point(8, 42);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Palette = this._styleform;
            this.lbltotal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lbltotal.Size = new System.Drawing.Size(95, 17);
            this.lbltotal.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbltotal.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.lbltotal.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbltotal.StateNormal.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.SystemDefault;
            this.lbltotal.StateNormal.TextColor = System.Drawing.Color.Red;
            this.lbltotal.Text = "      Total =0";
            this.lbltotal.UseWaitCursor = true;
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Red;
            this.lblRate.Image = ((System.Drawing.Image)(resources.GetObject("lblRate.Image")));
            this.lblRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblRate.Location = new System.Drawing.Point(8, 8);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.lblRate.Size = new System.Drawing.Size(81, 17);
            this.lblRate.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRate.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.lblRate.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRate.StateNormal.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.SystemDefault;
            this.lblRate.StateNormal.TextColor = System.Drawing.Color.Red;
            this.lblRate.Text = "      1$ = 4200៛";
            this.lblRate.UseWaitCursor = true;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(27, 95);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(80, 22);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateNormal.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonLabel5.TabIndex = 97;
            this.kryptonLabel5.Values.Text = "Product :";
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonWrapLabel1.Image")));
            this.kryptonWrapLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(14, 4);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(451, 13);
            this.kryptonWrapLabel1.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.kryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonWrapLabel1.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateNormal.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWrapLabel1.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonWrapLabel1.StateNormal.TextColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Text = "        F1 : Clear , F2 : Customer ,F3 : Add product  , F5 : Invoice List ,F7 : C" +
    "ommit";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 63);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(93, 22);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateNormal.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonLabel2.TabIndex = 85;
            this.kryptonLabel2.Values.Text = "Customer :";
            // 
            // cbocustomer
            // 
            this.cbocustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocustomer.DropDownWidth = 263;
            this.cbocustomer.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbocustomer.Location = new System.Drawing.Point(108, 60);
            this.cbocustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbocustomer.MaxDropDownItems = 15;
            this.cbocustomer.Name = "cbocustomer";
            this.cbocustomer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbocustomer.Size = new System.Drawing.Size(387, 29);
            this.cbocustomer.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cbocustomer.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbocustomer.StateActive.ComboBox.Border.Rounding = 10;
            this.cbocustomer.StateActive.ComboBox.Border.Width = 1;
            this.cbocustomer.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocustomer.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbocustomer.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cbocustomer.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cbocustomer.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbocustomer.StateCommon.ComboBox.Border.Width = 1;
            this.cbocustomer.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateCommon.Item.Border.Rounding = 10;
            this.cbocustomer.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.cbocustomer.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocustomer.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cbocustomer.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateNormal.ComboBox.Border.Rounding = 10;
            this.cbocustomer.StateNormal.ComboBox.Border.Width = 1;
            this.cbocustomer.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateNormal.Item.Border.Rounding = 10;
            this.cbocustomer.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbocustomer.StateTracking.Item.Border.Rounding = 10;
            this.cbocustomer.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cbocustomer.TabIndex = 84;
            this.cbocustomer.Text = "Choose System Control";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2;
            this.kryptonLabel1.Location = new System.Drawing.Point(32, 32);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 22);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonLabel1.TabIndex = 83;
            this.kryptonLabel1.Values.Text = "Invoice : ";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Location = new System.Drawing.Point(108, 30);
            this.txtinvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(387, 27);
            this.txtinvoice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtinvoice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtinvoice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtinvoice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtinvoice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtinvoice.StateCommon.Border.Rounding = 10;
            this.txtinvoice.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtinvoice.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtinvoice.TabIndex = 82;
            this.txtinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoice_KeyPress);
            // 
            // cboproduct
            // 
            this.cboproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboproduct.DropDownWidth = 263;
            this.cboproduct.Location = new System.Drawing.Point(108, 92);
            this.cboproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboproduct.MaxDropDownItems = 15;
            this.cboproduct.Name = "cboproduct";
            this.cboproduct.Size = new System.Drawing.Size(387, 29);
            this.cboproduct.StateActive.ComboBox.Border.ColorAngle = 10F;
            this.cboproduct.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboproduct.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cboproduct.StateActive.ComboBox.Border.Rounding = 10;
            this.cboproduct.StateActive.ComboBox.Border.Width = 1;
            this.cboproduct.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboproduct.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cboproduct.StateCommon.ComboBox.Border.ColorAngle = 30F;
            this.cboproduct.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboproduct.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.cboproduct.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboproduct.StateCommon.ComboBox.Border.Width = 1;
            this.cboproduct.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboproduct.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cboproduct.StateCommon.Item.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.cboproduct.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboproduct.StateCommon.Item.Border.Rounding = 10;
            this.cboproduct.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboproduct.StateCommon.Item.Content.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.cboproduct.StateCommon.Item.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cboproduct.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboproduct.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.cboproduct.StateDisabled.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cboproduct.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboproduct.StateNormal.ComboBox.Border.Rounding = 10;
            this.cboproduct.StateNormal.ComboBox.Border.Width = 1;
            this.cboproduct.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboproduct.StateNormal.Item.Border.Rounding = 10;
            this.cboproduct.StateTracking.Item.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.cboproduct.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboproduct.StateTracking.Item.Border.Rounding = 10;
            this.cboproduct.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.cboproduct.TabIndex = 81;
            this.cboproduct.SelectedIndexChanged += new System.EventHandler(this.cboproduct_SelectedIndexChanged);
            // 
            // dgPos
            // 
            this.dgPos.AllowUserToAddRows = false;
            this.dgPos.AllowUserToDeleteRows = false;
            this.dgPos.AllowUserToResizeColumns = false;
            this.dgPos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
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
            this.dgPos.Location = new System.Drawing.Point(0, 137);
            this.dgPos.Margin = new System.Windows.Forms.Padding(4);
            this.dgPos.MultiSelect = false;
            this.dgPos.Name = "dgPos";
            this.dgPos.RowHeadersVisible = false;
            this.dgPos.RowHeadersWidth = 51;
            this.dgPos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            this.dgPos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPos.Size = new System.Drawing.Size(1145, 548);
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
            this.dgPos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPos.StateCommon.HeaderRow.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.dgPos.StateCommon.HeaderRow.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.dgPos.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgPos.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Cooper Black", 11.25F);
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
            this.dgPos.StateSelected.HeaderRow.Content.Color1 = System.Drawing.Color.Navy;
            this.dgPos.TabIndex = 113;
            this.dgPos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellClick);
            this.dgPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellClick);
            this.dgPos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellEndEdit);
            this.dgPos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPos_KeyDown);
            // 
            // vNum
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.vbatch_id.HeaderText = "BatchID";
            this.vbatch_id.Name = "vbatch_id";
            // 
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._POS_add_batch,
            this.toolStripSeparator1,
            this._POS_merch_batch,
            this.toolStripSeparator2,
            this._POS_delete});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(193, 82);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _POS_add_batch
            // 
            this._POS_add_batch.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._POS_add_batch.Image = ((System.Drawing.Image)(resources.GetObject("_POS_add_batch.Image")));
            this._POS_add_batch.Name = "_POS_add_batch";
            this._POS_add_batch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this._POS_add_batch.Size = new System.Drawing.Size(192, 22);
            this._POS_add_batch.Text = "Add Batch";
            this._POS_add_batch.Click += new System.EventHandler(this._POS_add_batch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // _POS_merch_batch
            // 
            this._POS_merch_batch.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._POS_merch_batch.Image = ((System.Drawing.Image)(resources.GetObject("_POS_merch_batch.Image")));
            this._POS_merch_batch.Name = "_POS_merch_batch";
            this._POS_merch_batch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this._POS_merch_batch.Size = new System.Drawing.Size(192, 22);
            this._POS_merch_batch.Text = "Merch Batch";
            this._POS_merch_batch.Click += new System.EventHandler(this._POS_merch_batch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // _POS_delete
            // 
            this._POS_delete.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._POS_delete.Image = ((System.Drawing.Image)(resources.GetObject("_POS_delete.Image")));
            this._POS_delete.Name = "_POS_delete";
            this._POS_delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._POS_delete.Size = new System.Drawing.Size(192, 22);
            this._POS_delete.Text = "Delete";
            this._POS_delete.Click += new System.EventHandler(this._POS_delete_Click);
            // 
            // _menu_short
            // 
            this._menu_short.AllowMerge = false;
            this._menu_short.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._menu_short.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._menu_short.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Function});
            this._menu_short.Location = new System.Drawing.Point(0, 137);
            this._menu_short.Name = "_menu_short";
            this._menu_short.Size = new System.Drawing.Size(1145, 32);
            this._menu_short.TabIndex = 114;
            this._menu_short.Visible = false;
            // 
            // Function
            // 
            this.Function.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clear,
            this._Customer,
            this._AddNew,
            this._draft,
            this._POS,
            this._exit});
            this.Function.Image = ((System.Drawing.Image)(resources.GetObject("Function.Image")));
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(46, 28);
            this.Function.Text = ".";
            this.Function.Click += new System.EventHandler(this.Function_Click);
            // 
            // _clear
            // 
            this._clear.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clear.Name = "_clear";
            this._clear.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._clear.Size = new System.Drawing.Size(191, 22);
            this._clear.Text = "Clear";
            this._clear.Click += new System.EventHandler(this._clear_Click);
            // 
            // _Customer
            // 
            this._Customer.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Customer.Name = "_Customer";
            this._Customer.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this._Customer.Size = new System.Drawing.Size(191, 22);
            this._Customer.Text = "Search Customer";
            this._Customer.Click += new System.EventHandler(this._Customer_Click);
            // 
            // _AddNew
            // 
            this._AddNew.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._AddNew.Name = "_AddNew";
            this._AddNew.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._AddNew.Size = new System.Drawing.Size(191, 22);
            this._AddNew.Text = "Add Product";
            this._AddNew.Click += new System.EventHandler(this._AddNew_Click);
            // 
            // _draft
            // 
            this._draft.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._draft.Name = "_draft";
            this._draft.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this._draft.Size = new System.Drawing.Size(191, 22);
            this._draft.Text = "Draft";
            this._draft.Click += new System.EventHandler(this._draft_Click);
            // 
            // _POS
            // 
            this._POS.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._POS.Name = "_POS";
            this._POS.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this._POS.Size = new System.Drawing.Size(191, 22);
            this._POS.Text = "POS";
            this._POS.Click += new System.EventHandler(this._POS_Click);
            // 
            // _exit
            // 
            this._exit.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exit.Name = "_exit";
            this._exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this._exit.Size = new System.Drawing.Size(191, 22);
            this._exit.Text = "Exit";
            this._exit.Click += new System.EventHandler(this._exit_Click);
            // 
            // FrmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1145, 685);
            this.Controls.Add(this._menu_short);
            this.Controls.Add(this.dgPos);
            this.Controls.Add(this._gTop);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPOS";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.Color1 = System.Drawing.SystemColors.ControlLight;
            this.StateActive.Border.Color2 = System.Drawing.SystemColors.ControlLight;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.StateActive.Header.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.StateActive.Header.Border.Color1 = System.Drawing.SystemColors.ControlLight;
            this.StateActive.Header.Border.Color2 = System.Drawing.SystemColors.ControlLight;
            this.StateActive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateInactive.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.StateInactive.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.StateInactive.Header.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.StateInactive.Header.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.StateInactive.Header.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StateInactive.Header.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "FrmPOS";
            this.Load += new System.EventHandler(this.FrmPOS_Load);
            this.Shown += new System.EventHandler(this.frmPOS_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._gTop)).EndInit();
            this._gTop.ResumeLayout(false);
            this._gTop.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbocustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).EndInit();
            this._MenuFunction.ResumeLayout(false);
            this._menu_short.ResumeLayout(false);
            this._menu_short.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel _gTop;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbocustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtinvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboproduct;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgPos;
        private System.Windows.Forms.MenuStrip _menu_short;
        private System.Windows.Forms.ToolStripMenuItem Function;
        private System.Windows.Forms.ToolStripMenuItem _Customer;
        private System.Windows.Forms.ToolStripMenuItem _AddNew;
        private System.Windows.Forms.ToolStripMenuItem _POS;
        private System.Windows.Forms.ToolStripMenuItem _draft;
        private System.Windows.Forms.ToolStripMenuItem _clear;
        private System.Windows.Forms.ToolStripMenuItem _exit;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _POS_add_batch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _POS_delete;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lbltotal;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblRate;
        private System.Windows.Forms.ToolStripMenuItem _POS_merch_batch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblRunning;
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
    }
}