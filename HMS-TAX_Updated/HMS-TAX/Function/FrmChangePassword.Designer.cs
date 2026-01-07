namespace HMS_TAX.Function
{
    partial class FrmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnCommit = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtConpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnCommit.Location = new System.Drawing.Point(367, -1);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(58, 68);
            this.btnCommit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(-4, 36);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(102, 37);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Con-Password :";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(-4, -2);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 37);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "Password :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtConpassword
            // 
            // 
            // 
            // 
            this.txtConpassword.Border.Class = "TextBoxBorder";
            this.txtConpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtConpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtConpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtConpassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtConpassword.Location = new System.Drawing.Point(104, 40);
            this.txtConpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConpassword.Name = "txtConpassword";
            this.txtConpassword.Size = new System.Drawing.Size(256, 29);
            this.txtConpassword.TabIndex = 1;
            this.txtConpassword.UseSystemPasswordChar = true;
            this.txtConpassword.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtConpassword.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtConpassword.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtConpassword.WatermarkText = "ពាក្យសម្ងាត់";
            this.txtConpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtpassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtpassword.Location = new System.Drawing.Point(104, 2);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(256, 29);
            this.txtpassword.TabIndex = 0;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpassword.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.txtpassword.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtpassword.WatermarkText = "ពាក្យសម្ងាត់";
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(427, 79);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtConpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnCommit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePassword";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.Text = "FrmChangePassword";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private DevComponents.DotNetBar.ButtonX btnCommit;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtConpassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
    }
}