namespace FactorioImager
{
    partial class FactorioImagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactorioImagerWindow));
            this.gbGridSettings = new System.Windows.Forms.GroupBox();
            this.nudXoff = new System.Windows.Forms.NumericUpDown();
            this.nudYoff = new System.Windows.Forms.NumericUpDown();
            this.nudGridSize = new System.Windows.Forms.NumericUpDown();
            this.lblXoff = new System.Windows.Forms.Label();
            this.lblYoff = new System.Windows.Forms.Label();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.gbColorMap = new System.Windows.Forms.GroupBox();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.lblLimit = new System.Windows.Forms.Label();
            this.pbGridView = new System.Windows.Forms.PictureBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.gbGridView = new System.Windows.Forms.GroupBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.gbPropSelect = new System.Windows.Forms.GroupBox();
            this.btnGenerateBlueprint = new System.Windows.Forms.Button();
            this.txtBlueprint = new System.Windows.Forms.TextBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.txtPropName = new System.Windows.Forms.TextBox();
            this.rbEntity = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.btnUpdatePreview = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbInvert = new System.Windows.Forms.CheckBox();
            this.gbGridSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).BeginInit();
            this.gbColorMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.gbGridView.SuspendLayout();
            this.gbPropSelect.SuspendLayout();
            this.gbPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGridSettings
            // 
            this.gbGridSettings.Controls.Add(this.lblGridSize);
            this.gbGridSettings.Controls.Add(this.lblYoff);
            this.gbGridSettings.Controls.Add(this.lblXoff);
            this.gbGridSettings.Controls.Add(this.nudGridSize);
            this.gbGridSettings.Controls.Add(this.nudYoff);
            this.gbGridSettings.Controls.Add(this.nudXoff);
            this.gbGridSettings.Location = new System.Drawing.Point(324, 12);
            this.gbGridSettings.Name = "gbGridSettings";
            this.gbGridSettings.Size = new System.Drawing.Size(133, 99);
            this.gbGridSettings.TabIndex = 0;
            this.gbGridSettings.TabStop = false;
            this.gbGridSettings.Text = "&Grid settings";
            // 
            // nudXoff
            // 
            this.nudXoff.Location = new System.Drawing.Point(63, 19);
            this.nudXoff.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudXoff.Name = "nudXoff";
            this.nudXoff.Size = new System.Drawing.Size(57, 20);
            this.nudXoff.TabIndex = 2;
            // 
            // nudYoff
            // 
            this.nudYoff.Location = new System.Drawing.Point(63, 45);
            this.nudYoff.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudYoff.Name = "nudYoff";
            this.nudYoff.Size = new System.Drawing.Size(57, 20);
            this.nudYoff.TabIndex = 4;
            // 
            // nudGridSize
            // 
            this.nudGridSize.Location = new System.Drawing.Point(63, 71);
            this.nudGridSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGridSize.Name = "nudGridSize";
            this.nudGridSize.Size = new System.Drawing.Size(57, 20);
            this.nudGridSize.TabIndex = 6;
            this.nudGridSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGridSize.ValueChanged += new System.EventHandler(this.nudGridSize_ValueChanged);
            // 
            // lblXoff
            // 
            this.lblXoff.AutoSize = true;
            this.lblXoff.Location = new System.Drawing.Point(11, 21);
            this.lblXoff.Name = "lblXoff";
            this.lblXoff.Size = new System.Drawing.Size(46, 13);
            this.lblXoff.TabIndex = 1;
            this.lblXoff.Text = "&X offset:";
            // 
            // lblYoff
            // 
            this.lblYoff.AutoSize = true;
            this.lblYoff.Location = new System.Drawing.Point(11, 47);
            this.lblYoff.Name = "lblYoff";
            this.lblYoff.Size = new System.Drawing.Size(46, 13);
            this.lblYoff.TabIndex = 3;
            this.lblYoff.Text = "&Y offset:";
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Location = new System.Drawing.Point(7, 73);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(50, 13);
            this.lblGridSize.TabIndex = 5;
            this.lblGridSize.Text = "Grid &size:";
            // 
            // gbColorMap
            // 
            this.gbColorMap.Controls.Add(this.cbInvert);
            this.gbColorMap.Controls.Add(this.lblLimit);
            this.gbColorMap.Controls.Add(this.nudLimit);
            this.gbColorMap.Location = new System.Drawing.Point(324, 117);
            this.gbColorMap.Name = "gbColorMap";
            this.gbColorMap.Size = new System.Drawing.Size(133, 70);
            this.gbColorMap.TabIndex = 7;
            this.gbColorMap.TabStop = false;
            this.gbColorMap.Text = "&Map";
            // 
            // nudLimit
            // 
            this.nudLimit.Location = new System.Drawing.Point(63, 19);
            this.nudLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(57, 20);
            this.nudLimit.TabIndex = 9;
            this.nudLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(26, 21);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(31, 13);
            this.lblLimit.TabIndex = 8;
            this.lblLimit.Text = "&Limit:";
            // 
            // pbGridView
            // 
            this.pbGridView.Location = new System.Drawing.Point(6, 19);
            this.pbGridView.Name = "pbGridView";
            this.pbGridView.Size = new System.Drawing.Size(294, 305);
            this.pbGridView.TabIndex = 8;
            this.pbGridView.TabStop = false;
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(6, 19);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(300, 305);
            this.pbPreview.TabIndex = 9;
            this.pbPreview.TabStop = false;
            // 
            // gbGridView
            // 
            this.gbGridView.Controls.Add(this.pbGridView);
            this.gbGridView.Location = new System.Drawing.Point(12, 12);
            this.gbGridView.Name = "gbGridView";
            this.gbGridView.Size = new System.Drawing.Size(306, 331);
            this.gbGridView.TabIndex = 100;
            this.gbGridView.TabStop = false;
            this.gbGridView.Text = "Grid &view:";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 349);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(106, 23);
            this.btnLoadImage.TabIndex = 16;
            this.btnLoadImage.Text = "&Load image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // gbPropSelect
            // 
            this.gbPropSelect.Controls.Add(this.rbTile);
            this.gbPropSelect.Controls.Add(this.rbEntity);
            this.gbPropSelect.Controls.Add(this.txtPropName);
            this.gbPropSelect.Location = new System.Drawing.Point(324, 193);
            this.gbPropSelect.Name = "gbPropSelect";
            this.gbPropSelect.Size = new System.Drawing.Size(133, 96);
            this.gbPropSelect.TabIndex = 11;
            this.gbPropSelect.TabStop = false;
            this.gbPropSelect.Text = "&Prop selection:";
            // 
            // btnGenerateBlueprint
            // 
            this.btnGenerateBlueprint.Location = new System.Drawing.Point(12, 378);
            this.btnGenerateBlueprint.Name = "btnGenerateBlueprint";
            this.btnGenerateBlueprint.Size = new System.Drawing.Size(106, 23);
            this.btnGenerateBlueprint.TabIndex = 17;
            this.btnGenerateBlueprint.Text = "Generate &blueprint";
            this.btnGenerateBlueprint.UseVisualStyleBackColor = true;
            this.btnGenerateBlueprint.Click += new System.EventHandler(this.btnGenerateBlueprint_Click);
            // 
            // txtBlueprint
            // 
            this.txtBlueprint.Location = new System.Drawing.Point(124, 349);
            this.txtBlueprint.Multiline = true;
            this.txtBlueprint.Name = "txtBlueprint";
            this.txtBlueprint.ReadOnly = true;
            this.txtBlueprint.Size = new System.Drawing.Size(617, 51);
            this.txtBlueprint.TabIndex = 18;
            this.txtBlueprint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBlueprint_MouseClick);
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.pbPreview);
            this.gbPreview.Location = new System.Drawing.Point(463, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(312, 331);
            this.gbPreview.TabIndex = 100;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Preview:";
            // 
            // txtPropName
            // 
            this.txtPropName.Location = new System.Drawing.Point(6, 19);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.Size = new System.Drawing.Size(121, 20);
            this.txtPropName.TabIndex = 12;
            this.txtPropName.Text = "stone-wall";
            // 
            // rbEntity
            // 
            this.rbEntity.AutoSize = true;
            this.rbEntity.Checked = true;
            this.rbEntity.Location = new System.Drawing.Point(6, 45);
            this.rbEntity.Name = "rbEntity";
            this.rbEntity.Size = new System.Drawing.Size(51, 17);
            this.rbEntity.TabIndex = 13;
            this.rbEntity.TabStop = true;
            this.rbEntity.Text = "&Entity";
            this.rbEntity.UseVisualStyleBackColor = true;
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(6, 68);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(42, 17);
            this.rbTile.TabIndex = 14;
            this.rbTile.Text = "&Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePreview
            // 
            this.btnUpdatePreview.Location = new System.Drawing.Point(324, 295);
            this.btnUpdatePreview.Name = "btnUpdatePreview";
            this.btnUpdatePreview.Size = new System.Drawing.Size(133, 23);
            this.btnUpdatePreview.TabIndex = 15;
            this.btnUpdatePreview.Text = "&Upgrade grid";
            this.btnUpdatePreview.UseVisualStyleBackColor = true;
            this.btnUpdatePreview.Click += new System.EventHandler(this.btnUpdatePreview_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(747, 378);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 23);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.Location = new System.Drawing.Point(63, 45);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(53, 17);
            this.cbInvert.TabIndex = 10;
            this.cbInvert.Text = "&Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            // 
            // FactorioImagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 411);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnUpdatePreview);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.txtBlueprint);
            this.Controls.Add(this.gbPropSelect);
            this.Controls.Add(this.btnGenerateBlueprint);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.gbGridView);
            this.Controls.Add(this.gbColorMap);
            this.Controls.Add(this.gbGridSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FactorioImagerWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Factorio Imager";
            this.gbGridSettings.ResumeLayout(false);
            this.gbGridSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).EndInit();
            this.gbColorMap.ResumeLayout(false);
            this.gbColorMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.gbGridView.ResumeLayout(false);
            this.gbPropSelect.ResumeLayout(false);
            this.gbPropSelect.PerformLayout();
            this.gbPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGridSettings;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.Label lblYoff;
        private System.Windows.Forms.Label lblXoff;
        private System.Windows.Forms.NumericUpDown nudGridSize;
        private System.Windows.Forms.NumericUpDown nudYoff;
        private System.Windows.Forms.NumericUpDown nudXoff;
        private System.Windows.Forms.GroupBox gbColorMap;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.PictureBox pbGridView;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.GroupBox gbGridView;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.GroupBox gbPropSelect;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbEntity;
        private System.Windows.Forms.TextBox txtPropName;
        private System.Windows.Forms.Button btnGenerateBlueprint;
        private System.Windows.Forms.TextBox txtBlueprint;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Button btnUpdatePreview;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox cbInvert;
    }
}