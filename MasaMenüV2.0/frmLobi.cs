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
    public partial class frmLobi : Form
    {
        public frmLobi()
        {
            InitializeComponent();
        }

        Form1 frm = new Form1();
        private void btnMasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMasalar frmMs = new frmMasalar();
            frmMs.Show();
        }

        private void btnKullaniciAyari_Click(object sender, EventArgs e)
        {
            if (Form1.yetki) {
                frmKullaniciAyari frmKA = new frmKullaniciAyari();
                this.Close();
                frmKA.Show();
            }
            else {
                frmSifreDegistir frmSD = new frmSifreDegistir();
                this.Close();
                frmSD.Show();
            }
        }
        private void btnUrunAyari_Click(object sender, EventArgs e)
        {
            frmUrunAyarlari frmUA = new frmUrunAyarlari();
            this.Close();
            frmUA.Show();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            frmRaporlama frmR = new frmRaporlama();
            this.Close();
            frmR.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frm.Show();
        }

        private void frmLobi_Load(object sender, EventArgs e)
        {
            if (!Form1.yetki)
            {
                btnKullaniciAyari.Text = "Şifre Değiştir";
                btnRaporlama.Enabled = false;
                btnUrunAyari.Enabled = false;
            }
            serialPort1.PortName = "COM8";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void btnMAyari_Click(object sender, EventArgs e)
        {
            frmMasaAyari frmMA = new frmMasaAyari();
            this.Close();
            frmMA.Show();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            MasaMenuEntities db = new MasaMenuEntities();
            string deger = serialPort1.ReadExisting();
            string[] a = deger.Split('-');
            int masaID = Convert.ToInt32(a[1]);
            var masa = (from m in db.masalars where m.id ==masaID select m.adi).FirstOrDefault();
            
            if (a[0]=="A")
            {
                
                notifyIcon1.ShowBalloonTip(5000,masa.ToString(), "Garson çağırıyor", ToolTipIcon.Info);
                serialPort1.Write("#Garson bilgisi gönderildi.");
            }
            else if (a[0]=="B")
            {
                float ttl = Convert.ToSingle((from urun in db.urunlers.ToList()
                                              join sp in db.siparis on urun.id equals sp.urun_id
                                              where sp.masa_id == masaID
                                              where urun.id == sp.urun_id
                                              select (double?)urun.fiyati).Sum() ?? 0);
                notifyIcon1.ShowBalloonTip(5000, masa.ToString(), "Hesap istiyor \nToplam Tutar :"+ttl+"₺", ToolTipIcon.Info);
                serialPort1.Write("#Hesap bilgisi gönderildi.\nHesabınız:" + ttl + "₺");
            }
            else
            {

                if (a[0].IndexOf("*") != -1)
                {
                    string[] b = a[0].Split('*');
                    int urunID = Convert.ToInt32(b[0]);
                    var query = (from u in db.urunlers where u.id == urunID select u.ad).FirstOrDefault();
                    if (query!=null)
                    {
                        for (int i = 0; i < Convert.ToInt32(b[1]); i++)
                        {
                            sipari ekle = new sipari();
                            ekle.masa_id = masaID;
                            ekle.urun_id = urunID;
                            ekle.zaman = DateTime.Now.ToShortTimeString();
                            db.siparis.Add(ekle);
                            db.SaveChanges();
                        }

                        serialPort1.Write("#"+ b[1]+" adet "+query+" siparişi verilmiştir.");

                        notifyIcon1.ShowBalloonTip(5000, masa.ToString(),b[1] +" adet "+query+ " istiyor." , ToolTipIcon.Info);
                    }
                    else
                    {
                        serialPort1.Write("Ürün kodu bulunamamaktadır.");
                    }
                    
                }
                else
                {
                    int urunID = Convert.ToInt32(a[0]);
                    var query = (from u in db.urunlers where u.id == urunID select u.ad).FirstOrDefault();
                    if (query!=null)
                    {

                        sipari ekle = new sipari();
                        ekle.masa_id = masaID;
                        ekle.urun_id = urunID;
                        ekle.zaman = DateTime.Now.ToShortTimeString();
                        db.siparis.Add(ekle);
                        db.SaveChanges();

                        serialPort1.Write(query + " siparişi verilmiştir.");
                        notifyIcon1.ShowBalloonTip(5000, masa.ToString(),  query + " istiyor.", ToolTipIcon.Info);
                    }
                    else
                    {
                        serialPort1.Write("Ürün kodu bulunamamaktadır.");
                    }
                }
            }
        }
    }
}
