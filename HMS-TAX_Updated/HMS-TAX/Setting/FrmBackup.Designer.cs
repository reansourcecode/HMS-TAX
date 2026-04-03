namespace HMS_TAX.Setting
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this._styleform = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtLocaiton = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBrows = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommit = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFileName);
            this.groupBox1.Controls.Add(this.TxtLocaiton);
            this.groupBox1.Controls.Add(this.btnBrows);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // TxtFileName
            // 
            // 
            // 
            // 
            this.TxtFileName.Border.Class = "TextBoxBorder";
            this.TxtFileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtFileName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtFileName.Location = new System.Drawing.Point(112, 57);
            this.TxtFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(308, 29);
            this.TxtFileName.TabIndex = 14;
            this.TxtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFileName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TxtFileName.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtFileName.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.TxtFileName.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("TxtFileName.WatermarkImage")));
            this.TxtFileName.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtFileName.WatermarkText = "លេខសម្គាល់";
            // 
            // TxtLocaiton
            // 
            // 
            // 
            // 
            this.TxtLocaiton.Border.Class = "TextBoxBorder";
            this.TxtLocaiton.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtLocaiton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLocaiton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtLocaiton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtLocaiton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtLocaiton.Location = new System.Drawing.Point(112, 23);
            this.TxtLocaiton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLocaiton.Name = "TxtLocaiton";
            this.TxtLocaiton.Size = new System.Drawing.Size(271, 29);
            this.TxtLocaiton.TabIndex = 13;
            this.TxtLocaiton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLocaiton.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TxtLocaiton.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtLocaiton.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F);
            this.TxtLocaiton.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("TxtLocaiton.WatermarkImage")));
            this.TxtLocaiton.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtLocaiton.WatermarkText = "លេខសម្គាល់";
            // 
            // btnBrows
            // 
            this.btnBrows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrows.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrows.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnBrows.Image = ((System.Drawing.Image)(resources.GetObject("btnBrows.Image")));
            this.btnBrows.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnBrows.Location = new System.Drawing.Point(386, 25);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(34, 26);
            this.btnBrows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrows.TabIndex = 13;
            this.btnBrows.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location :";
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
            this.btnCommit.Location = new System.Drawing.Point(113, 117);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(329, 46);
            this.btnCommit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCommit.TabIndex = 14;
            this.btnCommit.Text = "&Click to Backup";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 172);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.Palette = this._styleform;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("CooperFiveOpti Black", 9.749999F, System.Drawing.FontStyle.Bold);
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("CooperFiveOpti Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateInactive.Header.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StateInactive.Header.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("CooperFiveOpti Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "FrmBackup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette _styleform;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnBrows;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtLocaiton;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtFileName;
        private DevComponents.DotNetBar.ButtonX btnCommit;
    }
}