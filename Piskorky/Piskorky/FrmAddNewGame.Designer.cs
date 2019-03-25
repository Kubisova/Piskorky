namespace Piskorky
{
    partial class FrmAddNewGame
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
            this.lblDimensions = new System.Windows.Forms.Label();
            this.lblPocetZaskrtnuti = new System.Windows.Forms.Label();
            this.lblPocetHracov = new System.Windows.Forms.Label();
            this.txb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblZnacka1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.txtNumberOfSigns = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(23, 28);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(109, 13);
            this.lblDimensions.TabIndex = 0;
            this.lblDimensions.Text = "Rozmer hracej plochy";
            // 
            // lblPocetZaskrtnuti
            // 
            this.lblPocetZaskrtnuti.AutoSize = true;
            this.lblPocetZaskrtnuti.Location = new System.Drawing.Point(23, 59);
            this.lblPocetZaskrtnuti.Name = "lblPocetZaskrtnuti";
            this.lblPocetZaskrtnuti.Size = new System.Drawing.Size(85, 13);
            this.lblPocetZaskrtnuti.TabIndex = 5;
            this.lblPocetZaskrtnuti.Text = "Počet zaškrtnutí";
            // 
            // lblPocetHracov
            // 
            this.lblPocetHracov.AutoSize = true;
            this.lblPocetHracov.Location = new System.Drawing.Point(23, 90);
            this.lblPocetHracov.Name = "lblPocetHracov";
            this.lblPocetHracov.Size = new System.Drawing.Size(71, 13);
            this.lblPocetHracov.TabIndex = 7;
            this.lblPocetHracov.Text = "Počet hráčov";
            // 
            // txb
            // 
            this.txb.Location = new System.Drawing.Point(180, 132);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(49, 20);
            this.txb.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblZnacka1
            // 
            this.lblZnacka1.AutoSize = true;
            this.lblZnacka1.Location = new System.Drawing.Point(23, 132);
            this.lblZnacka1.Name = "lblZnacka1";
            this.lblZnacka1.Size = new System.Drawing.Size(104, 13);
            this.lblZnacka1.TabIndex = 11;
            this.lblZnacka1.Text = "Značka pre 1. hráča";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(23, 174);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 13);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Značka pre 2. hráča";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(180, 90);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown4.TabIndex = 16;
            this.numericUpDown4.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(364, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(180, 28);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.Size = new System.Drawing.Size(49, 20);
            this.txtDimensions.TabIndex = 18;
            // 
            // txtNumberOfSigns
            // 
            this.txtNumberOfSigns.Location = new System.Drawing.Point(180, 59);
            this.txtNumberOfSigns.Name = "txtNumberOfSigns";
            this.txtNumberOfSigns.Size = new System.Drawing.Size(49, 20);
            this.txtNumberOfSigns.TabIndex = 19;
            // 
            // FrmAddNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 352);
            this.Controls.Add(this.txtNumberOfSigns);
            this.Controls.Add(this.txtDimensions);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblZnacka1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txb);
            this.Controls.Add(this.lblPocetHracov);
            this.Controls.Add(this.lblPocetZaskrtnuti);
            this.Controls.Add(this.lblDimensions);
            this.Name = "FrmAddNewGame";
            this.Text = "Pridaj novú hru";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label lblPocetZaskrtnuti;
        private System.Windows.Forms.Label lblPocetHracov;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblZnacka1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.TextBox txtNumberOfSigns;
    }
}