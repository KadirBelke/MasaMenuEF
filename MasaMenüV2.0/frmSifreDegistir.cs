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
    public partial class frmSifreDegistir : Form
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
        }
        MasaMenuEntities db = new MasaMenuEntities();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncel = (from person in db.personels where person.pId == Form1.id select person).Single();
            if (guncel.pPass==txtEski.Text)
            {
                guncel.pPass = txtYeni.Text;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz şifrenizi doğru giriniz!");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmLobi frm = new frmLobi();
            this.Close();
            frm.Show();
        }
    }
}
