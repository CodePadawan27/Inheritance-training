namespace PerintaHarjoitus
{
    partial class Paaikkuna
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
            this.PelementtiLuontiGroupBox = new System.Windows.Forms.GroupBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sadesarmaLabel = new System.Windows.Forms.Label();
            this.variLabel = new System.Windows.Forms.Label();
            this.pixelNappi = new System.Windows.Forms.Button();
            this.ympyraNappi = new System.Windows.Forms.Button();
            this.nelioNappi = new System.Windows.Forms.Button();
            this.variComboBox = new System.Windows.Forms.ComboBox();
            this.piirtoElementitGroupBox = new System.Windows.Forms.GroupBox();
            this.piirtoElementitListBox = new System.Windows.Forms.ListBox();
            this.piirtoNappi = new System.Windows.Forms.Button();
            this.tyhjennaNappi = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.sadesarmaTextBox = new System.Windows.Forms.TextBox();
            this.piirtoalustaPictureBox = new System.Windows.Forms.PictureBox();
            this.tyhjennaListaNappi = new System.Windows.Forms.Button();
            this.PelementtiLuontiGroupBox.SuspendLayout();
            this.piirtoElementitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piirtoalustaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PelementtiLuontiGroupBox
            // 
            this.PelementtiLuontiGroupBox.Controls.Add(this.sadesarmaTextBox);
            this.PelementtiLuontiGroupBox.Controls.Add(this.yTextBox);
            this.PelementtiLuontiGroupBox.Controls.Add(this.xTextBox);
            this.PelementtiLuontiGroupBox.Controls.Add(this.variComboBox);
            this.PelementtiLuontiGroupBox.Controls.Add(this.nelioNappi);
            this.PelementtiLuontiGroupBox.Controls.Add(this.ympyraNappi);
            this.PelementtiLuontiGroupBox.Controls.Add(this.pixelNappi);
            this.PelementtiLuontiGroupBox.Controls.Add(this.variLabel);
            this.PelementtiLuontiGroupBox.Controls.Add(this.sadesarmaLabel);
            this.PelementtiLuontiGroupBox.Controls.Add(this.yLabel);
            this.PelementtiLuontiGroupBox.Controls.Add(this.xLabel);
            this.PelementtiLuontiGroupBox.Location = new System.Drawing.Point(12, 22);
            this.PelementtiLuontiGroupBox.Name = "PelementtiLuontiGroupBox";
            this.PelementtiLuontiGroupBox.Size = new System.Drawing.Size(501, 217);
            this.PelementtiLuontiGroupBox.TabIndex = 0;
            this.PelementtiLuontiGroupBox.TabStop = false;
            this.PelementtiLuontiGroupBox.Text = "Piirtoelementtien luonti";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(33, 31);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(33, 70);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 0;
            this.yLabel.Text = "Y";
            // 
            // sadesarmaLabel
            // 
            this.sadesarmaLabel.AutoSize = true;
            this.sadesarmaLabel.Location = new System.Drawing.Point(33, 109);
            this.sadesarmaLabel.Name = "sadesarmaLabel";
            this.sadesarmaLabel.Size = new System.Drawing.Size(63, 13);
            this.sadesarmaLabel.TabIndex = 0;
            this.sadesarmaLabel.Text = "säde/särmä";
            // 
            // variLabel
            // 
            this.variLabel.AutoSize = true;
            this.variLabel.Location = new System.Drawing.Point(33, 148);
            this.variLabel.Name = "variLabel";
            this.variLabel.Size = new System.Drawing.Size(25, 13);
            this.variLabel.TabIndex = 0;
            this.variLabel.Text = "Väri";
            // 
            // pixelNappi
            // 
            this.pixelNappi.Location = new System.Drawing.Point(391, 31);
            this.pixelNappi.Name = "pixelNappi";
            this.pixelNappi.Size = new System.Drawing.Size(75, 23);
            this.pixelNappi.TabIndex = 5;
            this.pixelNappi.Text = "Pixel";
            this.pixelNappi.UseVisualStyleBackColor = true;
            this.pixelNappi.Click += new System.EventHandler(this.pixelNappi_Click);
            // 
            // ympyraNappi
            // 
            this.ympyraNappi.Location = new System.Drawing.Point(391, 60);
            this.ympyraNappi.Name = "ympyraNappi";
            this.ympyraNappi.Size = new System.Drawing.Size(75, 23);
            this.ympyraNappi.TabIndex = 6;
            this.ympyraNappi.Text = "Ympyrä";
            this.ympyraNappi.UseVisualStyleBackColor = true;
            this.ympyraNappi.Click += new System.EventHandler(this.ympyraNappi_Click);
            // 
            // nelioNappi
            // 
            this.nelioNappi.Location = new System.Drawing.Point(391, 89);
            this.nelioNappi.Name = "nelioNappi";
            this.nelioNappi.Size = new System.Drawing.Size(75, 23);
            this.nelioNappi.TabIndex = 7;
            this.nelioNappi.Text = "Neliö";
            this.nelioNappi.UseVisualStyleBackColor = true;
            this.nelioNappi.Click += new System.EventHandler(this.nelioNappi_Click);
            // 
            // variComboBox
            // 
            this.variComboBox.FormattingEnabled = true;
            this.variComboBox.Location = new System.Drawing.Point(114, 148);
            this.variComboBox.Name = "variComboBox";
            this.variComboBox.Size = new System.Drawing.Size(121, 21);
            this.variComboBox.TabIndex = 3;
            // 
            // piirtoElementitGroupBox
            // 
            this.piirtoElementitGroupBox.Controls.Add(this.piirtoElementitListBox);
            this.piirtoElementitGroupBox.Controls.Add(this.tyhjennaNappi);
            this.piirtoElementitGroupBox.Controls.Add(this.tyhjennaListaNappi);
            this.piirtoElementitGroupBox.Controls.Add(this.piirtoNappi);
            this.piirtoElementitGroupBox.Location = new System.Drawing.Point(629, 22);
            this.piirtoElementitGroupBox.Name = "piirtoElementitGroupBox";
            this.piirtoElementitGroupBox.Size = new System.Drawing.Size(428, 217);
            this.piirtoElementitGroupBox.TabIndex = 1;
            this.piirtoElementitGroupBox.TabStop = false;
            this.piirtoElementitGroupBox.Text = "Piirtoelementit";
            // 
            // piirtoElementitListBox
            // 
            this.piirtoElementitListBox.FormattingEnabled = true;
            this.piirtoElementitListBox.Location = new System.Drawing.Point(20, 31);
            this.piirtoElementitListBox.Name = "piirtoElementitListBox";
            this.piirtoElementitListBox.Size = new System.Drawing.Size(385, 134);
            this.piirtoElementitListBox.TabIndex = 0;
            this.piirtoElementitListBox.TabStop = false;
            // 
            // piirtoNappi
            // 
            this.piirtoNappi.Location = new System.Drawing.Point(20, 188);
            this.piirtoNappi.Name = "piirtoNappi";
            this.piirtoNappi.Size = new System.Drawing.Size(75, 23);
            this.piirtoNappi.TabIndex = 8;
            this.piirtoNappi.Text = "Piirrä";
            this.piirtoNappi.UseVisualStyleBackColor = true;
            this.piirtoNappi.Click += new System.EventHandler(this.piirtoNappi_Click);
            // 
            // tyhjennaNappi
            // 
            this.tyhjennaNappi.Location = new System.Drawing.Point(125, 188);
            this.tyhjennaNappi.Name = "tyhjennaNappi";
            this.tyhjennaNappi.Size = new System.Drawing.Size(160, 23);
            this.tyhjennaNappi.TabIndex = 9;
            this.tyhjennaNappi.Text = "Tyhjennä piirtoalusta";
            this.tyhjennaNappi.UseVisualStyleBackColor = true;
            this.tyhjennaNappi.Click += new System.EventHandler(this.tyhjennaNappi_Click);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(114, 31);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(71, 20);
            this.xTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(114, 70);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(71, 20);
            this.yTextBox.TabIndex = 1;
            // 
            // sadesarmaTextBox
            // 
            this.sadesarmaTextBox.Location = new System.Drawing.Point(114, 109);
            this.sadesarmaTextBox.Name = "sadesarmaTextBox";
            this.sadesarmaTextBox.Size = new System.Drawing.Size(71, 20);
            this.sadesarmaTextBox.TabIndex = 2;
            // 
            // piirtoalustaPictureBox
            // 
            this.piirtoalustaPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.piirtoalustaPictureBox.Location = new System.Drawing.Point(12, 304);
            this.piirtoalustaPictureBox.Name = "piirtoalustaPictureBox";
            this.piirtoalustaPictureBox.Size = new System.Drawing.Size(1045, 313);
            this.piirtoalustaPictureBox.TabIndex = 2;
            this.piirtoalustaPictureBox.TabStop = false;
            // 
            // tyhjennaListaNappi
            // 
            this.tyhjennaListaNappi.Location = new System.Drawing.Point(315, 188);
            this.tyhjennaListaNappi.Name = "tyhjennaListaNappi";
            this.tyhjennaListaNappi.Size = new System.Drawing.Size(90, 23);
            this.tyhjennaListaNappi.TabIndex = 8;
            this.tyhjennaListaNappi.Text = "Tyhjenna lista";
            this.tyhjennaListaNappi.UseVisualStyleBackColor = true;
            this.tyhjennaListaNappi.Click += new System.EventHandler(this.tyhjennaListaNappi_Click);
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 629);
            this.Controls.Add(this.piirtoalustaPictureBox);
            this.Controls.Add(this.piirtoElementitGroupBox);
            this.Controls.Add(this.PelementtiLuontiGroupBox);
            this.Name = "Paaikkuna";
            this.Text = "Form1";
            this.PelementtiLuontiGroupBox.ResumeLayout(false);
            this.PelementtiLuontiGroupBox.PerformLayout();
            this.piirtoElementitGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piirtoalustaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PelementtiLuontiGroupBox;
        private System.Windows.Forms.TextBox sadesarmaTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.ComboBox variComboBox;
        private System.Windows.Forms.Button nelioNappi;
        private System.Windows.Forms.Button ympyraNappi;
        private System.Windows.Forms.Button pixelNappi;
        private System.Windows.Forms.Label variLabel;
        private System.Windows.Forms.Label sadesarmaLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.GroupBox piirtoElementitGroupBox;
        private System.Windows.Forms.ListBox piirtoElementitListBox;
        private System.Windows.Forms.Button tyhjennaNappi;
        private System.Windows.Forms.Button piirtoNappi;
        private System.Windows.Forms.PictureBox piirtoalustaPictureBox;
        private System.Windows.Forms.Button tyhjennaListaNappi;
    }
}

