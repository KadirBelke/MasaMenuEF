using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasaMenüV2._0
{
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }
        MasaMenuEntities db = new MasaMenuEntities();
        private void frmMasalar_Load(object sender, EventArgs e)
        {

            cmbGrup.DisplayMember = "adi";
            cmbGrup.ValueMember = "id";
            cmbGrup.DataSource = db.grups.ToList();
            islem((int)nud.Value);
        }
        public void islem(int a)
        {
            while (grbButonlar.Controls.Count != 0)
            {
                grbButonlar.Controls.Remove(grbButonlar.Controls[0]);
            }
            var ms = from masa in db.masalars where masa.gId == (int)cmbGrup.SelectedValue select masa;
            if (36 >= ms.Count())
            {
                nud.Hide();
            }
            int enlem = 1;
            int boylam = 1;
            int s1 = 36 * (a - 1);
            int s2 = 0;
            foreach (var masa in ms)
            {
                if (s1 > s2 || s1 + 36 <= s2)
                {
                    s2++;
                    continue;
                }
                if (enlem >= 10)
                {
                    enlem = 1;
                    boylam++;
                }
                Button btn = new Button();
                btn.Location = new Point(148 * enlem - 140, 150 * boylam - 140);
                btn.Size = new Size(145, 120);
                string zaman = "";
                var se = (from s in db.siparis where s.masa_id == masa.id select s).FirstOrDefault();
                if (null !=se )
                {
                    zaman = (Convert.ToDateTime(DateTime.Now.ToShortTimeString()) - Convert.ToDateTime(se.zaman)).ToString();
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Green;
                }
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Standard;
                btn.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                btn.Text = masa.adi + "\n\t" + zaman;
                btn.Name = "btn" + masa.id ; 
                grbButonlar.Controls.Add(btn);
                btn.Click += btnClick;
                enlem++;
                s2++;
            }
        }
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            frmSiparis frm = new frmSiparis();
            frm.masaId = btn.Name.Remove(0, 3);
            frm.masaAdi = btn.Text;
            this.Hide();
            frm.Show();
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            islem((int)nud.Value);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmLobi frm = new frmLobi();
            this.Close();
            frm.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            islem(1);
        }
    }
}
