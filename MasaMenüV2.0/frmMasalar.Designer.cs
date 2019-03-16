namespace MasaMenüV2._0
{
    partial class frmMasalar
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
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.grbButonlar = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // nud
            // 
            this.nud.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nud.Location = new System.Drawing.Point(300, 353);
            this.nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(34, 20);
            this.nud.TabIndex = 0;
            this.nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // grbButonlar
            // 
            this.grbButonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbButonlar.BackColor = System.Drawing.Color.Transparent;
            this.grbButonlar.Location = new System.Drawing.Point(12, 26);
            this.grbButonlar.Name = "grbButonlar";
            this.grbButonlar.Size = new System.Drawing.Size(600, 321);
            this.grbButonlar.TabIndex = 1;
            this.grbButonlar.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeri.Location = new System.Drawing.Point(12, 353);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cmbGrup
            // 
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Location = new System.Drawing.Point(12, 12);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(121, 21);
            this.cmbGrup.TabIndex = 3;
            this.cmbGrup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasaMenüV2._0.Properties.Resources.wood_background_with_ivy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 385);
            this.Controls.Add(this.cmbGrup);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.grbButonlar);
            this.Controls.Add(this.nud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMasalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmMasalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMasalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.GroupBox grbButonlar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ComboBox cmbGrup;
    }
}