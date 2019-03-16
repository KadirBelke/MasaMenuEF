namespace MasaMenüV2._0
{
    partial class frmRaporlama
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
            this.lvHesap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYK = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSGK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSAK = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSYK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvHesap
            // 
            this.lvHesap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvHesap.GridLines = true;
            this.lvHesap.Location = new System.Drawing.Point(203, 49);
            this.lvHesap.Name = "lvHesap";
            this.lvHesap.Size = new System.Drawing.Size(361, 409);
            this.lvHesap.TabIndex = 1;
            this.lvHesap.UseCompatibleStateImageBehavior = false;
            this.lvHesap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alınan fiyat ";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saat";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Masa Adı";
            this.columnHeader3.Width = 119;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(743, 418);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(83, 40);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(601, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Günlük Kazanç :";
            // 
            // lblGK
            // 
            this.lblGK.AutoSize = true;
            this.lblGK.BackColor = System.Drawing.Color.Transparent;
            this.lblGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGK.ForeColor = System.Drawing.Color.Black;
            this.lblGK.Location = new System.Drawing.Point(747, 135);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(34, 20);
            this.lblGK.TabIndex = 5;
            this.lblGK.Text = "0 ₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(601, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aylık Kazanç :";
            // 
            // lblAK
            // 
            this.lblAK.AutoSize = true;
            this.lblAK.BackColor = System.Drawing.Color.Transparent;
            this.lblAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAK.ForeColor = System.Drawing.Color.Black;
            this.lblAK.Location = new System.Drawing.Point(727, 170);
            this.lblAK.Name = "lblAK";
            this.lblAK.Size = new System.Drawing.Size(34, 20);
            this.lblAK.TabIndex = 7;
            this.lblAK.Text = "0 ₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(601, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yıllık Kazanç :";
            // 
            // lblYK
            // 
            this.lblYK.AutoSize = true;
            this.lblYK.BackColor = System.Drawing.Color.Transparent;
            this.lblYK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYK.ForeColor = System.Drawing.Color.Black;
            this.lblYK.Location = new System.Drawing.Point(727, 205);
            this.lblYK.Name = "lblYK";
            this.lblYK.Size = new System.Drawing.Size(34, 20);
            this.lblYK.TabIndex = 9;
            this.lblYK.Text = "0 ₺";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblSGK
            // 
            this.lblSGK.AutoSize = true;
            this.lblSGK.BackColor = System.Drawing.Color.Transparent;
            this.lblSGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSGK.ForeColor = System.Drawing.Color.Black;
            this.lblSGK.Location = new System.Drawing.Point(812, 240);
            this.lblSGK.Name = "lblSGK";
            this.lblSGK.Size = new System.Drawing.Size(34, 20);
            this.lblSGK.TabIndex = 13;
            this.lblSGK.Text = "0 ₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(601, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seçilen Günün Kazancı :";
            // 
            // lblSAK
            // 
            this.lblSAK.AutoSize = true;
            this.lblSAK.BackColor = System.Drawing.Color.Transparent;
            this.lblSAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSAK.ForeColor = System.Drawing.Color.Black;
            this.lblSAK.Location = new System.Drawing.Point(792, 275);
            this.lblSAK.Name = "lblSAK";
            this.lblSAK.Size = new System.Drawing.Size(34, 20);
            this.lblSAK.TabIndex = 15;
            this.lblSAK.Text = "0 ₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(601, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seçilen Ayın Kazancı :";
            // 
            // lblSYK
            // 
            this.lblSYK.AutoSize = true;
            this.lblSYK.BackColor = System.Drawing.Color.Transparent;
            this.lblSYK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSYK.ForeColor = System.Drawing.Color.Black;
            this.lblSYK.Location = new System.Drawing.Point(792, 310);
            this.lblSYK.Name = "lblSYK";
            this.lblSYK.Size = new System.Drawing.Size(34, 20);
            this.lblSYK.TabIndex = 17;
            this.lblSYK.Text = "0 ₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(601, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Seçilen Yılın Kazancı :";
            // 
            // frmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasaMenüV2._0.Properties.Resources.wood_background_with_ivy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 484);
            this.Controls.Add(this.lblSYK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSAK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSGK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblYK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lvHesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRaporlama";
            this.Load += new System.EventHandler(this.frmRaporlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHesap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSGK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSAK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSYK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}