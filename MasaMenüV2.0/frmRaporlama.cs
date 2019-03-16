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
    public partial class frmRaporlama : Form
    {
        public frmRaporlama()
        {
            InitializeComponent();
        }

        MasaMenuEntities db = new MasaMenuEntities();
        public void lv()
        {
            lvHesap.Items.Clear();
            var cmt = from hesap in db.hesaps.ToList()
                      join masa in db.masalars on hesap.MId equals masa.id
                      where hesap.gun == Convert.ToInt32(dateTimePicker1.Value.ToString("dd"))
                      where hesap.ay == Convert.ToInt32(dateTimePicker1.Value.ToString("MM"))
                      where hesap.yil == Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"))
                      select new { hsp = hesap, ms = masa.adi };
            foreach (var item in cmt)
            {
                ListViewItem lvAdd = new ListViewItem(item.hsp.Total.ToString());
                lvAdd.SubItems.Add(item.hsp.saat + ":" + item.hsp.dakika + ":" + item.hsp.saniye);
                lvAdd.SubItems.Add(item.ms.ToString());
                lvHesap.Items.Add(lvAdd);
            }
            lblSGK.Text = (from hsp in db.hesaps.ToList()
                           where hsp.gun == Convert.ToInt32(dateTimePicker1.Value.ToString("dd"))
                           where hsp.ay == Convert.ToInt32(dateTimePicker1.Value.ToString("MM"))
                           where hsp.yil == Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"))
                           select hsp.Total).Sum() + " ₺";

            lblSAK.Text = (from hsp in db.hesaps.ToList()
                           where hsp.ay == Convert.ToInt32(dateTimePicker1.Value.ToString("MM"))
                           where hsp.yil == Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"))
                           select hsp.Total).Sum() + " ₺";

            lblSYK.Text = (from hsp in db.hesaps.ToList()
                           where hsp.yil == Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"))
                           select hsp.Total).Sum() + " ₺";
        }

        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            lv();
            DateTime dt = DateTime.Now;
            lblGK.Text = ((from hsp in db.hesaps
                          where hsp.gun == dt.Day
                          where hsp.ay == dt.Month
                          where hsp.yil == dt.Year
                          select (double?)hsp.Total).Sum()??0)+"₺" ;

            lblAK.Text = ((from hsp in db.hesaps
                          where hsp.ay == dt.Month
                          where hsp.yil == dt.Year
                          select (double?)hsp.Total).Sum()??0) + " ₺";

            lblYK.Text = ((from hsp in db.hesaps
                          where hsp.yil == dt.Year
                          select (double?)hsp.Total).Sum()??0)+ " ₺";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmLobi frm = new frmLobi();
            this.Close();
            frm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lv();
        }
    }
}
