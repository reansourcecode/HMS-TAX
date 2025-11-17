namespace HMS_TAX.HMS
{
    partial class FrmSearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgSearch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.vProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.Location = new System.Drawing.Point(112, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(471, 29);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSearch.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearch.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtSearch.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.WatermarkImage")));
            this.txtSearch.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSearch.WatermarkText = "លេខសម្គាល់";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(10, 11);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 37);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Search :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgSearch
            // 
            this.dgSearch.AllowUserToAddRows = false;
            this.dgSearch.AllowUserToDeleteRows = false;
            this.dgSearch.AllowUserToResizeColumns = false;
            this.dgSearch.AllowUserToResizeRows = false;
            this.dgSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.dgSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgSearch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vProID,
            this.vName,
            this.vLine,
            this.vMol,
            this.vPack,
            this.vStatus});
            this.dgSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSearch.Location = new System.Drawing.Point(9, 57);
            this.dgSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.ReadOnly = true;
            this.dgSearch.RowHeadersVisible = false;
            this.dgSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSearch.Size = new System.Drawing.Size(866, 564);
            this.dgSearch.StandardTab = true;
            this.dgSearch.TabIndex = 18;
            this.dgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellContentClick);
            this.dgSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellContentDoubleClick);
            // 
            // vProID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vProID.DefaultCellStyle = dataGridViewCellStyle1;
            this.vProID.HeaderText = "Items Name";
            this.vProID.Name = "vProID";
            this.vProID.ReadOnly = true;
            // 
            // vName
            // 
            this.vName.HeaderText = "Name";
            this.vName.Name = "vName";
            this.vName.ReadOnly = true;
            // 
            // vLine
            // 
            this.vLine.HeaderText = "Line";
            this.vLine.Name = "vLine";
            this.vLine.ReadOnly = true;
            // 
            // vMol
            // 
            this.vMol.HeaderText = "Molecule";
            this.vMol.Name = "vMol";
            this.vMol.ReadOnly = true;
            // 
            // vPack
            // 
            this.vPack.HeaderText = "Packing";
            this.vPack.Name = "vPack";
            this.vPack.ReadOnly = true;
            // 
            // vStatus
            // 
            this.vStatus.HeaderText = "Active";
            this.vStatus.Name = "vStatus";
            this.vStatus.ReadOnly = true;
            // 
            // FrmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 637);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgSearch);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchProduct";
            this.Load += new System.EventHandler(this.FrmSearchProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn vProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn vStatus;

    }
}