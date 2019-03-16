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
    public partial class frmUrunAyarlari : Form
    {
        public frmUrunAyarlari()
        {
            InitializeComponent();
        }
        MasaMenuEntities db = new MasaMenuEntities();
        string KId;
        string UId;
        private void frmUrunAyarlari_Load(object sender, EventArgs e)
        {
            klv();
        }
        //list view ve comboboxların kategori kısmını doldurur.
        public void klv()
        {
            lvKategori.Items.Clear();
            var cmt = from ktgr in db.kategoris select ktgr;
            foreach (var item in cmt)
            {
                ListViewItem lv = new ListViewItem(item.adi.ToString());
                lv.SubItems.Add(item.id.ToString());
                lvKategori.Items.Add(lv);
            }
            cmb1.DisplayMember = "adi";
            cmb1.ValueMember = "id";
            cmb1.DataSource = db.kategoris.ToList();
            cmb2.DisplayMember = "adi";
            cmb2.ValueMember = "id";
            cmb2.DataSource = db.kategoris.ToList();
            ulv();

        }
        //Ürünler listviewini doldurur
        public void ulv()
        {
            lvUrunler.Items.Clear();
            var cmt = from urun in db.urunlers  where urun.kId == (int)cmb2.SelectedValue select urun;
            foreach (var item in cmt)
            {
                ListViewItem lv = new ListViewItem(item.id.ToString());
                lv.SubItems.Add(item.ad.ToString());
                lv.SubItems.Add(item.fiyati.ToString());
                lvUrunler.Items.Add(lv);
            }
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ulv();
        }

        private void btnKEkle_Click(object sender, EventArgs e)
        {
            kategori ktgr = new kategori();
            ktgr.adi = txtKategori.Text;
            db.kategoris.Add(ktgr);
            db.SaveChanges();
            klv();
        }

        private void lvKategori_MouseClick(object sender, MouseEventArgs e)
        {
            txtSil.Text = lvKategori.SelectedItems[0].SubItems[0].Text;
            KId = lvKategori.SelectedItems[0].SubItems[1].Text;
        }

        private void btnKGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = (from ktgr in db.kategoris.ToList() where ktgr.id == Convert.ToInt32(KId) select ktgr).Single();
            guncelle.adi = txtKategori.Text;
            db.SaveChanges();
            klv();
            
        }

        private void btnKSil_Click(object sender, EventArgs e)
        {
            if (null==(from urun in db.urunlers.ToList() where urun.kId==Convert.ToInt32(KId) select urun).FirstOrDefault())
            {
                db.kategoris.Remove((from ktgr in db.kategoris.ToList() where ktgr.id == Convert.ToInt32(KId) select ktgr).Single());
                db.SaveChanges();
                klv();
            }
            else
            {
                MessageBox.Show("Bu kategoriye bağlı ürünler olduğundan işlem gerçekleştirilemyor!");
            }
        }

        private void lvUrunler_MouseClick(object sender, MouseEventArgs e)
        {
            txtKt.Text = cmb2.Text;
            UId = lvUrunler.SelectedItems[0].SubItems[0].Text;
            txtAd2.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            txtfiyat2.Text = lvUrunler.SelectedItems[0].SubItems[2].Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunler urun = new urunler();
            urun.ad = txtAd1.Text;
            urun.fiyati =Convert.ToDouble(txtfiyat1.Text);
            urun.kId = (int)cmb1.SelectedValue;
            db.urunlers.Add(urun);
            db.SaveChanges();
            ulv();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = (from urun in db.urunlers.ToList() where urun.id == Convert.ToInt32(UId) select urun).Single();
            guncelle.ad = txtAd1.Text;
            guncelle.fiyati = Convert.ToDouble(txtfiyat1.Text);
            guncelle.kId = (int)cmb1.SelectedValue;
            db.SaveChanges();
            ulv();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.urunlers.Remove((from urun in db.urunlers.ToList() where urun.id == Convert.ToInt32(UId) select urun).Single());
            db.SaveChanges();
            ulv();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmLobi frm = new frmLobi();
            this.Close();
            frm.Show();
        }
    }
}
