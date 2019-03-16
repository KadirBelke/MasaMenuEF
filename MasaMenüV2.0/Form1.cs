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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int id;
        public static bool yetki;
        MasaMenuEntities db = new MasaMenuEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var giris = (from p in db.personels where p.pName == txtKullaniciAdi.Text && p.pPass == txtSifre.Text select p).FirstOrDefault();
            if (null != giris)
            {
                id = giris.pId;
                yetki = giris.yetki;
                frmLobi frmlb = new frmLobi();
                this.Hide();
                frmlb.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!\nKulanıcı Adı veye Şifre hatalı!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnGiris_Click(sender,e);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
