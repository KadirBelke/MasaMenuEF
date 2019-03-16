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
    public partial class frmMasaAyari : Form
    {
        public frmMasaAyari()
        {
            InitializeComponent();
        }
        MasaMenuEntities db = new MasaMenuEntities();
        string GId;
        string MId;
        public void Glv()
        {
            lvGrup.Items.Clear();
            var cmt = from gr in db.grups select gr;
            foreach (var item in cmt)
            {
                ListViewItem lv = new ListViewItem(item.adi.ToString());
                lv.SubItems.Add(item.id.ToString());
                lvGrup.Items.Add(lv);
            }
            cmb1.DisplayMember = "adi";
            cmb1.ValueMember = "id";
            cmb1.DataSource = db.grups.ToList();
            cmb2.DisplayMember = "adi";
            cmb2.ValueMember = "id";
            cmb2.DataSource = db.grups.ToList();
            Mlv();
        }
        public void Mlv()
        {
            lvMasalar.Items.Clear();
            var cmt = from masa in db.masalars where masa.gId == (int)cmb2.SelectedValue select masa;
            foreach (var item in cmt)
            {
                ListViewItem lv = new ListViewItem(item.id.ToString());
                lv.SubItems.Add(item.adi.ToString());
                lvMasalar.Items.Add(lv);
            }
        }
        private void btnGEkle_Click(object sender, EventArgs e)
        {
            grup gr = new grup();
            gr.adi = txtGrup.Text;
            db.grups.Add(gr);
            db.SaveChanges();
            Glv();
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mlv();
        }

        private void lvGrup_MouseClick(object sender, MouseEventArgs e)
        {
            txtSil.Text = lvGrup.SelectedItems[0].SubItems[1].Text;
            GId = lvGrup.SelectedItems[0].SubItems[0].Text;
        }

        private void btnGGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = (from gr in db.grups.ToList() where gr.id == Convert.ToInt32(GId) select gr).Single();
            guncelle.adi = txtGrup.Text;
            db.SaveChanges();
            Glv();
        }

        private void btnGSil_Click(object sender, EventArgs e)
        {
            if (null == (from ms in db.masalars.ToList() where ms.gId == Convert.ToInt32(GId) select ms).FirstOrDefault())
            {
                db.grups.Remove((from gr in db.grups.ToList() where gr.id == Convert.ToInt32(GId) select gr).Single());
                db.SaveChanges();
                Glv();
            }
            else
            {
                MessageBox.Show("Bu gruba bağlı masalar olduğundan işlem gerçekleştirilemyor!");
            }
        }

        private void lvMasalar_MouseClick(object sender, MouseEventArgs e)
        {
            txtGr.Text = cmb2.Text;
            MId = lvMasalar.SelectedItems[0].SubItems[0].Text;
            txtAd2.Text = lvMasalar.SelectedItems[0].SubItems[1].Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            masalar ms = new masalar();
            ms.adi = txtAd1.Text;
            ms.gId = (int)cmb1.SelectedValue;
            db.masalars.Add(ms);
            db.SaveChanges();
            Mlv();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = (from ms in db.masalars.ToList() where ms.id == Convert.ToInt32(MId) select ms).Single();
            guncelle.adi = txtAd1.Text;
            guncelle.gId = (int)cmb1.SelectedValue;
            db.SaveChanges();
            Mlv();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.masalars.Remove((from ms in db.masalars.ToList() where ms.id == Convert.ToInt32(MId) select ms).Single());
            db.SaveChanges();
            Mlv();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmLobi frm = new frmLobi();
            this.Close();
            frm.Show();
        }

        private void frmMasaAyari_Load(object sender, EventArgs e)
        {
            Glv();
        }
    }
}
