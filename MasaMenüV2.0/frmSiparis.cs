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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        public string masaId;
        public string masaAdi;
        public string urunId;
        MasaMenuEntities db = new MasaMenuEntities();
        public void splv()
        {
            lvSiparis.Items.Clear();
            var sp = from urun in db.urunlers.ToList()
                     join sipariss in db.siparis 
                     on urun.id equals sipariss.urun_id
                     where sipariss.masa_id == Convert.ToInt32(masaId)
                     select urun;
            foreach (var item in sp)
            {
                ListViewItem lv = new ListViewItem(item.id.ToString());
                lv.SubItems.Add(item.ad.ToString());
                lv.SubItems.Add(item.fiyati.ToString());
                lvSiparis.Items.Add(lv);
            }
            label2.Text = total() + "₺";
            label4.Text = stotal() + "₺";
        }
        public float total()
        {
            float ttl = Convert.ToSingle((from urun in db.urunlers.ToList()
                         join sp in db.siparis on urun.id equals sp.urun_id
                         where sp.masa_id == Convert.ToInt32(masaId)
                         where urun.id == sp.urun_id
                         select (double?)urun.fiyati).Sum()??0);
            return ttl;
        }
        public void ekle(float ttl)
        {
            hesap ekle = new hesap();
            DateTime dt = DateTime.Now;
            ekle.Total = Convert.ToDouble(ttl);
            ekle.gun = dt.Day;
            ekle.ay = dt.Month;
            ekle.yil = dt.Year;
            ekle.saat = dt.Hour;
            ekle.dakika = dt.Minute;
            ekle.saniye = dt.Second;
            ekle.MId = Convert.ToInt32(masaId);
            db.hesaps.Add(ekle);
            db.SaveChanges();
        }
        public float stotal()
        {
            float total = 0;
            for (int i = 0; i < lvSiparis.Items.Count; i++)
            {
                if (lvSiparis.Items[i].Checked)
                {
                    total += Convert.ToSingle((lvSiparis.Items[i].SubItems[2].Text).Replace(".", ","));
                }
            }
            label4.Text = total + "₺";
            return total;
        }
        public void sil()
        {
            for (int i = 0; i < lvSiparis.Items.Count; i++)
            {
                if (lvSiparis.Items[i].Checked)
                {
                    db.siparis.Remove((from sipa in db.siparis.ToList()
                                       where sipa.masa_id == Convert.ToInt32(masaId)
                                       where sipa.urun_id == Convert.ToInt32(lvSiparis.Items[i].SubItems[0].Text)
                                       select sipa).FirstOrDefault());
                    db.SaveChanges();
                }
            }
            splv();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            lblNo.Text = masaAdi;
            cmbKatagori.DisplayMember = "adi";
            cmbKatagori.ValueMember = "id";
            cmbKatagori.DataSource = db.kategoris.ToList(); ;
            splv();
        }
        private void cmbKatagori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvUrunler.Items.Clear();
            var uruns = from urun in db.urunlers
                        where urun.kId == (int)cmbKatagori.SelectedValue
                        select urun;
            foreach (var item in uruns)
            {
                ListViewItem lv = new ListViewItem(item.id.ToString());
                lv.SubItems.Add(item.ad.ToString());
                lv.SubItems.Add(item.fiyati.ToString());
                lvUrunler.Items.Add(lv);
            }
        }
        private void lvUrunler_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrun.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            urunId = lvUrunler.SelectedItems[0].SubItems[0].Text;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (int)ndAdet.Value; i++)
            {
                sipari ekle = new sipari();
                ekle.masa_id = Convert.ToInt32(masaId);
                ekle.urun_id = Convert.ToInt32(urunId);
                ekle.zaman = DateTime.Now.ToShortTimeString();
                db.siparis.Add(ekle);
                db.SaveChanges();
            }
            ndAdet.Value = 1;
            splv();
        }
        private void btnHesap_Click(object sender, EventArgs e)
        {
            ekle(total());
            sipari sp = new sipari();
            var dlt = db.siparis.ToList().Where(w => w.masa_id == Convert.ToInt32(masaId));
            foreach (var item in dlt)
            {
                db.siparis.Remove(item);
            }
            
            db.SaveChanges();
            splv();
        }
        private void btnSHesap_Click(object sender, EventArgs e)
        {
            ekle(stotal());
            sil();
        }
        private void lvSiparis_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            stotal();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close();
            frm.Show();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            sil();
        }
            
    }
}
