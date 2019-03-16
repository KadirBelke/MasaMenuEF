namespace MasaMenüV2._0
{
    partial class frmLobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobi));
            this.btnMasa = new System.Windows.Forms.Button();
            this.btnKullaniciAyari = new System.Windows.Forms.Button();
            this.btnUrunAyari = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMAyari = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnMasa
            // 
            this.btnMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa.Location = new System.Drawing.Point(423, 228);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(167, 72);
            this.btnMasa.TabIndex = 0;
            this.btnMasa.Text = "Masalar";
            this.btnMasa.UseVisualStyleBackColor = true;
            this.btnMasa.Click += new System.EventHandler(this.btnMasa_Click);
            // 
            // btnKullaniciAyari
            // 
            this.btnKullaniciAyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciAyari.Location = new System.Drawing.Point(423, 306);
            this.btnKullaniciAyari.Name = "btnKullaniciAyari";
            this.btnKullaniciAyari.Size = new System.Drawing.Size(167, 72);
            this.btnKullaniciAyari.TabIndex = 0;
            this.btnKullaniciAyari.Text = "Kullanıcı Ayarları";
            this.btnKullaniciAyari.UseVisualStyleBackColor = true;
            this.btnKullaniciAyari.Click += new System.EventHandler(this.btnKullaniciAyari_Click);
            // 
            // btnUrunAyari
            // 
            this.btnUrunAyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAyari.Location = new System.Drawing.Point(596, 303);
            this.btnUrunAyari.Name = "btnUrunAyari";
            this.btnUrunAyari.Size = new System.Drawing.Size(167, 72);
            this.btnUrunAyari.TabIndex = 0;
            this.btnUrunAyari.Text = "Ürün Ayarları";
            this.btnUrunAyari.UseVisualStyleBackColor = true;
            this.btnUrunAyari.Click += new System.EventHandler(this.btnUrunAyari_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlama.Location = new System.Drawing.Point(423, 381);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(167, 72);
            this.btnRaporlama.TabIndex = 0;
            this.btnRaporlama.Text = "Raporlama";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(596, 381);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(167, 72);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMAyari
            // 
            this.btnMAyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMAyari.Location = new System.Drawing.Point(596, 228);
            this.btnMAyari.Name = "btnMAyari";
            this.btnMAyari.Size = new System.Drawing.Size(167, 72);
            this.btnMAyari.TabIndex = 0;
            this.btnMAyari.Text = "Masa Ayarları";
            this.btnMAyari.UseVisualStyleBackColor = true;
            this.btnMAyari.Click += new System.EventHandler(this.btnMAyari_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // frmLobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasaMenüV2._0.Properties.Resources.wood_background_with_ivy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnUrunAyari);
            this.Controls.Add(this.btnKullaniciAyari);
            this.Controls.Add(this.btnMAyari);
            this.Controls.Add(this.btnMasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLobi";
            this.Text = "Lobi";
            this.Load += new System.EventHandler(this.frmLobi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Button btnKullaniciAyari;
        private System.Windows.Forms.Button btnUrunAyari;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMAyari;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}