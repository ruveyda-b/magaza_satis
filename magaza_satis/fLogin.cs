using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magaza_satis
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            if (tKullaniciAdi.Text != "" && tSifre.Text != "")
            {
                try
                {
                    // ctrl+k & ctrl+c for comment
                    // ctrl+k & ctrl+u for uncomment

                    //using (var db = new BarkodDbEntities())
                    //{
                    //    if (db.Kullanici.Any())
                    //    {
                    //        var bak = db.Kullanici.Where(x => x.KullaniciAd == tKullaniciAdi.Text &&
                    //                                          x.Sifre == tSifre.Text).FirstOrDefault();
                    //        if(bak != null)
                    //        {
                    //            Cursor.Current = Cursors.WaitCursor;
                    //            fBaslangic f = new fBaslangic();
                    //            f.bSatisİslemi.Enabled = (bool)bak.Satis;
                    //            f.bStokTakibi.Enabled = (bool)bak.Stok;
                    //            f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                    //            f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                    //            f.bFiyatGuncelleme.Enabled = (bool)bak.FiyatGuncelle;
                    //            f.bYedekle.Enabled = (bool)bak.Yedekle;
                    //            f.lKullanici.Text = bak.AdSoyad;
                    //            f.Show();
                    //            this.Hide();
                    //            Cursor.Current = Cursors.Default;
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("Hatalı giriş!");
                    //        }
                    //    }
                    //}

                    // TODO: burayı test edip çalıştırabilmek için yazdım, db'ye göre yapılmalı
                    if (tKullaniciAdi.Text == "admin" && tSifre.Text == "admin")
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        fBaslangic f = new fBaslangic();
                        f.bSatisİslemi.Enabled = true;
                        f.bStokTakibi.Enabled = true;
                        f.bUrunGiris.Enabled = true;
                        // f.bAyarlar.Enabled = true; (ayarlar butonumuz yok)
                        f.bFiyatGuncelleme.Enabled = true;
                        f.bYedekle.Enabled = true;
                        f.lKullanici.Text = "Ruveyda Bingöl";
                        f.Show();
                        this.Hide();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        fBaslangic f = new fBaslangic();
                        f.bSatisİslemi.Enabled = false;
                        f.bStokTakibi.Enabled = false;
                        f.bUrunGiris.Enabled = false;
                        // f.bAyarlar.Enabled = false; (ayarlar butonumuz yok)
                        f.bFiyatGuncelleme.Enabled = false;
                        f.bYedekle.Enabled = false;
                        f.lKullanici.Text = "Geçersiz Kullanıcı";
                        f.Show();
                        this.Hide();
                        Cursor.Current = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }
    }
}
