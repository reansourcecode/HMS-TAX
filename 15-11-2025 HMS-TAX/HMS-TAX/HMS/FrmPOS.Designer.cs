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
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this._top = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMsg = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lbltotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.txtexchange = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbocustomer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtinvoice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cboproduct = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgPos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.vNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSysdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._POS_delete = new System.Windows.Forms.ToolStripMenuItem();
            this._menu_short = new System.Windows.Forms.MenuStrip();
            this.Function = new System.Windows.Forms.ToolStripMenuItem();
            this._Customer = new System.Windows.Forms.ToolStripMenuItem();
            this._SearchProduct = new System.Windows.Forms.ToolStripMenuItem();
            this._AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this._POS = new System.Windows.Forms.ToolStripMenuItem();
            this._draft = new System.Windows.Forms.ToolStripMenuItem();
            this._invoice = new System.Windows.Forms.ToolStripMenuItem();
            this._clear = new System.Windows.Forms.ToolStripMenuItem();
            this._exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._top)).BeginInit();
            this._top.SuspendLayout();
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
            // _top
            // 
            this._top.Controls.Add(this.kryptonLabel5);
            this._top.Controls.Add(this.lblMsg);
            this._top.Controls.Add(this.lbltotal);
            this._top.Controls.Add(this.kryptonWrapLabel1);
            this._top.Controls.Add(this.txtexchange);
            this._top.Controls.Add(this.kryptonLabel2);
            this._top.Controls.Add(this.cbocustomer);
            this._top.Controls.Add(this.kryptonLabel1);
            this._top.Controls.Add(this.txtinvoice);
            this._top.Controls.Add(this.cboproduct);
            this._top.Dock = System.Windows.Forms.DockStyle.Top;
            this._top.Location = new System.Drawing.Point(0, 0);
            this._top.Margin = new System.Windows.Forms.Padding(4);
            this._top.Name = "_top";
            this._top.Palette = this._styleform;
            this._top.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this._top.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this._top.Size = new System.Drawing.Size(1175, 145);
            this._top.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(31, 106);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(67, 21);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 97;
            this.kryptonLabel5.Values.Text = "Product";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMsg.Image = ((System.Drawing.Image)(resources.GetObject("lblMsg.Image")));
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsg.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblMsg.Location = new System.Drawing.Point(516, 69);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(72, 20);
            this.lblMsg.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.lblMsg.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMsg.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.lblMsg.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMsg.StateNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.StateNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMsg.Text = "      Msg";
            // 
            // lbltotal
            // 
            this.lbltotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbltotal.Location = new System.Drawing.Point(941, 105);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(50, 26);
            this.lbltotal.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbltotal.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.TabIndex = 90;
            this.lbltotal.Values.Text = "total";
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonWrapLabel1.Image")));
            this.kryptonWrapLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(14, 4);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(531, 15);
            this.kryptonWrapLabel1.StateCommon.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.kryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateDisabled.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonWrapLabel1.StateDisabled.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonWrapLabel1.StateNormal.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.kryptonWrapLabel1.StateNormal.TextColor = System.Drawing.Color.Green;
            this.kryptonWrapLabel1.Text = "        F1 : Clear , F2 : Customer ,F3 : Add product into list , F7 : Commit  =>F" +
    "5 : Draft , F6 : Invoice ";
            // 
            // txtexchange
            // 
            this.txtexchange.Enabled = false;
            this.txtexchange.Location = new System.Drawing.Point(501, 28);
            this.txtexchange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtexchange.Name = "txtexchange";
            this.txtexchange.ReadOnly = true;
            this.txtexchange.Size = new System.Drawing.Size(387, 27);
            this.txtexchange.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtexchange.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtexchange.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtexchange.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtexchange.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtexchange.StateCommon.Border.Rounding = 10;
            this.txtexchange.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtexchange.StateCommon.Content.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexchange.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtexchange.TabIndex = 86;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(17, 68);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 85;
            this.kryptonLabel2.Values.Text = "Customer";
            // 
            // cbocustomer
            // 
            this.cbocustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocustomer.DropDownWidth = 263;
            this.cbocustomer.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cbocustomer.Location = new System.Drawing.Point(108, 63);
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
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(35, 33);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(63, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 83;
            this.kryptonLabel1.Values.Text = "Invoice";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Location = new System.Drawing.Point(108, 28);
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
            // 
            // cboproduct
            // 
            this.cboproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboproduct.DropDownWidth = 263;
            this.cboproduct.Location = new System.Drawing.Point(108, 100);
            this.cboproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboproduct.MaxDropDownItems = 15;
            this.cboproduct.Name = "cboproduct";
            this.cboproduct.Size = new System.Drawing.Size(780, 29);
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
            this.dgPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNum,
            this.vSysdoc,
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
            this.dgPos.Size = new System.Drawing.Size(1175, 572);
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
            this.dgPos.TabIndex = 113;
            this.dgPos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellClick);
            this.dgPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellClick);
            // 
            // vNum
            // 
            this.vNum.HeaderText = "No";
            this.vNum.MinimumWidth = 6;
            this.vNum.Name = "vNum";
            this.vNum.Width = 125;
            // 
            // vSysdoc
            // 
            this.vSysdoc.HeaderText = "sysdocnum";
            this.vSysdoc.Name = "vSysdoc";
            // 
            // vName
            // 
            this.vName.HeaderText = "Items";
            this.vName.MinimumWidth = 6;
            this.vName.Name = "vName";
            this.vName.Width = 125;
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
            this.vbatch_id.HeaderText = "Batch";
            this.vbatch_id.Name = "vbatch_id";
            // 
            // _MenuFunction
            // 
            this._MenuFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._MenuFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._POS_add_batch,
            this.toolStripSeparator2,
            this._POS_delete});
            this._MenuFunction.Name = "_MenuFunction";
            this._MenuFunction.Size = new System.Drawing.Size(170, 54);
            this._MenuFunction.Opening += new System.ComponentModel.CancelEventHandler(this._MenuFunction_Opening);
            // 
            // _POS_add_batch
            // 
            this._POS_add_batch.Image = ((System.Drawing.Image)(resources.GetObject("_POS_add_batch.Image")));
            this._POS_add_batch.Name = "_POS_add_batch";
            this._POS_add_batch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this._POS_add_batch.Size = new System.Drawing.Size(169, 22);
            this._POS_add_batch.Text = "Add Batch";
            this._POS_add_batch.Click += new System.EventHandler(this._POS_add_batch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // _POS_delete
            // 
            this._POS_delete.Image = ((System.Drawing.Image)(resources.GetObject("_POS_delete.Image")));
            this._POS_delete.Name = "_POS_delete";
            this._POS_delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._POS_delete.Size = new System.Drawing.Size(169, 22);
            this._POS_delete.Text = "Delete";
            this._POS_delete.Click += new System.EventHandler(this._POS_delete_Click);
            // 
            // _menu_short
            // 
            this._menu_short.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._menu_short.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._menu_short.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Function});
            this._menu_short.Location = new System.Drawing.Point(0, 145);
            this._menu_short.Name = "_menu_short";
            this._menu_short.Size = new System.Drawing.Size(1175, 24);
            this._menu_short.TabIndex = 114;
            this._menu_short.Text = "menuStrip1";
            this._menu_short.Visible = false;
            // 
            // Function
            // 
            this.Function.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Customer,
            this._SearchProduct,
            this._AddNew,
            this._POS,
            this._draft,
            this._invoice,
            this._clear,
            this._exit});
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(66, 20);
            this.Function.Text = "Function";
            // 
            // _Customer
            // 
            this._Customer.Name = "_Customer";
            this._Customer.Size = new System.Drawing.Size(173, 22);
            this._Customer.Text = "Search Customer";
            // 
            // _SearchProduct
            // 
            this._SearchProduct.Name = "_SearchProduct";
            this._SearchProduct.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this._SearchProduct.Size = new System.Drawing.Size(173, 22);
            this._SearchProduct.Text = "Search Product";
            // 
            // _AddNew
            // 
            this._AddNew.Name = "_AddNew";
            this._AddNew.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this._AddNew.Size = new System.Drawing.Size(173, 22);
            this._AddNew.Text = "Add Product";
            this._AddNew.Click += new System.EventHandler(this._AddNew_Click);
            // 
            // _POS
            // 
            this._POS.Name = "_POS";
            this._POS.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this._POS.Size = new System.Drawing.Size(173, 22);
            this._POS.Text = "POS";
            this._POS.Click += new System.EventHandler(this._POS_Click);
            // 
            // _draft
            // 
            this._draft.Name = "_draft";
            this._draft.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this._draft.Size = new System.Drawing.Size(173, 22);
            this._draft.Text = "Draft";
            // 
            // _invoice
            // 
            this._invoice.Name = "_invoice";
            this._invoice.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this._invoice.Size = new System.Drawing.Size(173, 22);
            this._invoice.Text = "Invoice";
            // 
            // _clear
            // 
            this._clear.Name = "_clear";
            this._clear.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this._clear.Size = new System.Drawing.Size(173, 22);
            this._clear.Text = "Clear";
            // 
            // _exit
            // 
            this._exit.Name = "_exit";
            this._exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this._exit.Size = new System.Drawing.Size(173, 22);
            this._exit.Text = "Exit";
            // 
            // FrmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 717);
            this.Controls.Add(this._menu_short);
            this.Controls.Add(this.dgPos);
            this.Controls.Add(this._top);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPOS";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPOS";
            this.Load += new System.EventHandler(this.FrmPOS_Load);
            this.Shown += new System.EventHandler(this.frmPOS_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._top)).EndInit();
            this._top.ResumeLayout(false);
            this._top.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonPanel _top;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblMsg;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltotal;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtexchange;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbocustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtinvoice;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboproduct;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgPos;
        private System.Windows.Forms.MenuStrip _menu_short;
        private System.Windows.Forms.ToolStripMenuItem Function;
        private System.Windows.Forms.ToolStripMenuItem _Customer;
        private System.Windows.Forms.ToolStripMenuItem _SearchProduct;
        private System.Windows.Forms.ToolStripMenuItem _AddNew;
        private System.Windows.Forms.ToolStripMenuItem _POS;
        private System.Windows.Forms.ToolStripMenuItem _draft;
        private System.Windows.Forms.ToolStripMenuItem _invoice;
        private System.Windows.Forms.ToolStripMenuItem _clear;
        private System.Windows.Forms.ToolStripMenuItem _exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vSysdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpro_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn vsto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn vqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatch_id;
        private System.Windows.Forms.ContextMenuStrip _MenuFunction;
        private System.Windows.Forms.ToolStripMenuItem _POS_add_batch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _POS_delete;
    }
}