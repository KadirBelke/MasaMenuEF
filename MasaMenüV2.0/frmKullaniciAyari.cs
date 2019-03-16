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
    public partial class frmKullaniciAyari : Form
    {
        public frmKullaniciAyari()
        {
            InitializeComponent();
        }
        MasaMenuEntities db = new MasaMenuEntities();
        public void lv()
        {
            lvPersonel.Items.Clear();
            var getir = from person in db.personels select person;
            foreach (var item in getir)
            {
                ListViewItem lv = new ListViewItem(item.pName.ToString());
                lv.SubItems.Add(item.yetki.ToString());
                lvPersonel.Items.Add(lv);
            }
        }

        private void frmKullaniciAyari_Load(object sender, EventArgs e)
        {
            lv();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (null==(from person in db.personels where person.pName==txtAdi.Text select person).FirstOrDefault())
            {
                personel ps = new personel();
                ps.pName = txtAdi.Text;
                ps.pPass = "Cafe2017";
                ps.yetki = Convert.ToBoolean(nudYetki.Value);
                db.personels.Add(ps);
                db.SaveChanges();
                MessageBox.Show("Şifreniz Cafe2017 olarak kaydedilmişti.\n En kısa zamanda şifrenizi değiştirmenizi öneririz.");
                lv();
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı daha önceden alınmıştır!");
            }
        }

        private void lvPersonel_MouseClick(object sender, MouseEventArgs e)
        {
            txtAd2.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
            nudYetki2.Value = Convert.ToDecimal(Convert.ToBoolean(lvPersonel.SelectedItems[0].SubItems[1].Text));
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var ps = (from person in db.personels where person.pName == txtAd2.Text select person).Single();
            ps.yetki = Convert.ToBoolean(nudYetki2.Value);
            db.SaveChanges();
            lv();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.personels.Remove((from person in db.personels where person.pName == txtAd2.Text select person).Single());
            db.SaveChanges();
            lv();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmLobi frm = new frmLobi();
            this.Close();
            frm.Show();
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            frmSifreDegistir frm = new frmSifreDegistir();
            this.Close();
            frm.Show();
        }
    }
}
