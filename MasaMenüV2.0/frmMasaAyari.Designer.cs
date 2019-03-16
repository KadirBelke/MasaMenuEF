namespace MasaMenüV2._0
{
    partial class frmMasaAyari
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.txtGr = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAd2 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd1 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lvMasalar = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.btnGSil = new System.Windows.Forms.Button();
            this.btnGGuncelle = new System.Windows.Forms.Button();
            this.txtGrup = new System.Windows.Forms.TextBox();
            this.btnGEkle = new System.Windows.Forms.Button();
            this.lvGrup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(16, 424);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 28);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmb2);
            this.groupBox2.Controls.Add(this.txtGr);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.txtAd2);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtAd1);
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.lvMasalar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(361, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 380);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masa Ayarı";
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(20, 32);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(308, 24);
            this.cmb2.TabIndex = 11;
            this.cmb2.SelectedIndexChanged += new System.EventHandler(this.cmb2_SelectedIndexChanged);
            // 
            // txtGr
            // 
            this.txtGr.Enabled = false;
            this.txtGr.Location = new System.Drawing.Point(334, 201);
            this.txtGr.Name = "txtGr";
            this.txtGr.Size = new System.Drawing.Size(213, 23);
            this.txtGr.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(454, 279);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 82);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(334, 279);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(114, 82);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAd2
            // 
            this.txtAd2.Enabled = false;
            this.txtAd2.Location = new System.Drawing.Point(334, 241);
            this.txtAd2.Name = "txtAd2";
            this.txtAd2.Size = new System.Drawing.Size(213, 23);
            this.txtAd2.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(334, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(213, 68);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd1
            // 
            this.txtAd1.Location = new System.Drawing.Point(334, 72);
            this.txtAd1.Name = "txtAd1";
            this.txtAd1.Size = new System.Drawing.Size(206, 23);
            this.txtAd1.TabIndex = 3;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(334, 32);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(206, 24);
            this.cmb1.TabIndex = 2;
            // 
            // lvMasalar
            // 
            this.lvMasalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMasalar.GridLines = true;
            this.lvMasalar.Location = new System.Drawing.Point(20, 61);
            this.lvMasalar.Name = "lvMasalar";
            this.lvMasalar.Size = new System.Drawing.Size(308, 300);
            this.lvMasalar.TabIndex = 1;
            this.lvMasalar.UseCompatibleStateImageBehavior = false;
            this.lvMasalar.View = System.Windows.Forms.View.Details;
            this.lvMasalar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMasalar_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No ";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad";
            this.columnHeader3.Width = 246;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSil);
            this.groupBox1.Controls.Add(this.btnGSil);
            this.groupBox1.Controls.Add(this.btnGGuncelle);
            this.groupBox1.Controls.Add(this.txtGrup);
            this.groupBox1.Controls.Add(this.btnGEkle);
            this.groupBox1.Controls.Add(this.lvGrup);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 380);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grup Ayarı";
            // 
            // txtSil
            // 
            this.txtSil.Enabled = false;
            this.txtSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txtSil.Location = new System.Drawing.Point(24, 310);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(202, 20);
            this.txtSil.TabIndex = 5;
            // 
            // btnGSil
            // 
            this.btnGSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGSil.Location = new System.Drawing.Point(139, 339);
            this.btnGSil.Name = "btnGSil";
            this.btnGSil.Size = new System.Drawing.Size(87, 23);
            this.btnGSil.TabIndex = 4;
            this.btnGSil.Text = "SİL";
            this.btnGSil.UseVisualStyleBackColor = true;
            this.btnGSil.Click += new System.EventHandler(this.btnGSil_Click);
            // 
            // btnGGuncelle
            // 
            this.btnGGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGGuncelle.Location = new System.Drawing.Point(24, 339);
            this.btnGGuncelle.Name = "btnGGuncelle";
            this.btnGGuncelle.Size = new System.Drawing.Size(109, 23);
            this.btnGGuncelle.TabIndex = 3;
            this.btnGGuncelle.Text = "GÜNCELLE";
            this.btnGGuncelle.UseVisualStyleBackColor = true;
            this.btnGGuncelle.Click += new System.EventHandler(this.btnGGuncelle_Click);
            // 
            // txtGrup
            // 
            this.txtGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txtGrup.Location = new System.Drawing.Point(24, 281);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Size = new System.Drawing.Size(202, 20);
            this.txtGrup.TabIndex = 2;
            // 
            // btnGEkle
            // 
            this.btnGEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGEkle.Location = new System.Drawing.Point(232, 280);
            this.btnGEkle.Name = "btnGEkle";
            this.btnGEkle.Size = new System.Drawing.Size(87, 82);
            this.btnGEkle.TabIndex = 1;
            this.btnGEkle.Text = "EKLE";
            this.btnGEkle.UseVisualStyleBackColor = true;
            this.btnGEkle.Click += new System.EventHandler(this.btnGEkle_Click);
            // 
            // lvGrup
            // 
            this.lvGrup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5});
            this.lvGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvGrup.GridLines = true;
            this.lvGrup.Location = new System.Drawing.Point(24, 32);
            this.lvGrup.Name = "lvGrup";
            this.lvGrup.Size = new System.Drawing.Size(295, 243);
            this.lvGrup.TabIndex = 0;
            this.lvGrup.UseCompatibleStateImageBehavior = false;
            this.lvGrup.View = System.Windows.Forms.View.Details;
            this.lvGrup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvGrup_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 232;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "No";
            this.columnHeader5.Width = 57;
            // 
            // frmMasaAyari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasaMenüV2._0.Properties.Resources.wood_background_with_ivy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMasaAyari";
            this.Text = "frmMasaAyari";
            this.Load += new System.EventHandler(this.frmMasaAyari_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.TextBox txtGr;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAd2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ListView lvMasalar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.Button btnGSil;
        private System.Windows.Forms.Button btnGGuncelle;
        private System.Windows.Forms.TextBox txtGrup;
        private System.Windows.Forms.Button btnGEkle;
        private System.Windows.Forms.ListView lvGrup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}