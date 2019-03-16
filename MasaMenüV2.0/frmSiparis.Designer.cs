namespace MasaMenüV2._0
{
    partial class frmSiparis
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSHesap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSiparis = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHesap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ndAdet = new System.Windows.Forms.NumericUpDown();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.cmbKatagori = new System.Windows.Forms.ComboBox();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnIptal);
            this.groupBox2.Controls.Add(this.btnSHesap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lvSiparis);
            this.groupBox2.Controls.Add(this.btnHesap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(424, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 405);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şiparişler";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(179, 337);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(94, 49);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "SİPARİŞ   İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSHesap
            // 
            this.btnSHesap.Location = new System.Drawing.Point(279, 337);
            this.btnSHesap.Name = "btnSHesap";
            this.btnSHesap.Size = new System.Drawing.Size(92, 49);
            this.btnSHesap.TabIndex = 12;
            this.btnSHesap.Text = "SEÇİLEN HESAP";
            this.btnSHesap.UseVisualStyleBackColor = true;
            this.btnSHesap.Click += new System.EventHandler(this.btnSHesap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(122, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "0₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seçilen Tutar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "0₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tutar :";
            // 
            // lvSiparis
            // 
            this.lvSiparis.CheckBoxes = true;
            this.lvSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSiparis.GridLines = true;
            this.lvSiparis.Location = new System.Drawing.Point(20, 35);
            this.lvSiparis.Name = "lvSiparis";
            this.lvSiparis.Size = new System.Drawing.Size(451, 295);
            this.lvSiparis.TabIndex = 7;
            this.lvSiparis.UseCompatibleStateImageBehavior = false;
            this.lvSiparis.View = System.Windows.Forms.View.Details;
            this.lvSiparis.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvSiparis_ItemChecked);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün No";
            this.columnHeader4.Width = 61;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün Adı";
            this.columnHeader5.Width = 263;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Fiyatı";
            this.columnHeader6.Width = 123;
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(377, 337);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(94, 49);
            this.btnHesap.TabIndex = 4;
            this.btnHesap.Text = "HESAP";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ndAdet);
            this.groupBox1.Controls.Add(this.txtUrun);
            this.groupBox1.Controls.Add(this.cmbKatagori);
            this.groupBox1.Controls.Add(this.lvUrunler);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 405);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // ndAdet
            // 
            this.ndAdet.Location = new System.Drawing.Point(220, 336);
            this.ndAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndAdet.Name = "ndAdet";
            this.ndAdet.Size = new System.Drawing.Size(40, 20);
            this.ndAdet.TabIndex = 6;
            this.ndAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(20, 336);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(199, 20);
            this.txtUrun.TabIndex = 5;
            // 
            // cmbKatagori
            // 
            this.cmbKatagori.FormattingEnabled = true;
            this.cmbKatagori.Location = new System.Drawing.Point(20, 35);
            this.cmbKatagori.Name = "cmbKatagori";
            this.cmbKatagori.Size = new System.Drawing.Size(351, 21);
            this.cmbKatagori.TabIndex = 0;
            this.cmbKatagori.SelectedIndexChanged += new System.EventHandler(this.cmbKatagori_SelectedIndexChanged);
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.Location = new System.Drawing.Point(20, 61);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(351, 269);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvUrunler_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün No";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Fiyatı";
            this.columnHeader3.Width = 99;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(266, 337);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 49);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(795, 40);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(76, 31);
            this.lblNo.TabIndex = 12;
            this.lblNo.Text = "masa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasaMenüV2._0.Properties.Resources.wood_background_with_ivy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSHesap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSiparis;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ndAdet;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.ComboBox cmbKatagori;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIptal;
    }
}