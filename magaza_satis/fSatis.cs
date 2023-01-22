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
    public partial class fSatis : Form
    {
        public fSatis()
        {
            InitializeComponent();
        }
        private void fSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
        }

        private void HizliButonDoldur()
        {
            var hizliUrun = db.HizliUrun.ToList();
            foreach (var item in hizliUrun)
            {
                Button bH = this.Controls.Find("bH" + item.Id, true).FirstOrDefault() as Button;
                if (bH!=null)
                {
                    double fiyat = Islemler.DoubleYap(item.Fiyat.ToString());
                    bH.Text = item.UrunAd + "\n" + fiyat.ToString("C2"); // veritabanından verileri alıp hızlı işlemlere ekliyoruz.
                    // C2 para birimi
                }
            }
        }

        private void HizliButonClick(object sender, EventArgs e)
        {  
            Button b = (Button)sender;
            int buttonId = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));

            if (b.Text.ToString().StartsWith("-"))
            {
                fHizliButonUrunEkle f = new fHizliButonUrunEkle(); // diğer formu böyle açıyoruz
                f.lButonId.Text = buttonId.ToString();
                f.ShowDialog();
            }
            else
            {
                var urunbarkod = db.HizliUrun.Where(a => a.Id == buttonId).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunbarkod, Convert.ToDouble(tMiktar.Text));
                GenelToplam();
            }
            
        }

        BarkodDbEntities db = new BarkodDbEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim(); // boşlukları aldık Trim() fonks ile
                if (barkod.Length <= 2) // barkod alanına 2 veya altında karakter girerse miktar olarak alacağız yanlışlıkla girer falan
                {
                    tMiktar.Text = barkod;
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a=> a.Barkod==barkod)) // Any fonks bize true veya false değeri döndürür
                    {
                        // burada if bloğu çalıştığına göre ürün tablosunun barkod alanında barkod var demektir ve
                        // var tipinde oluşturulan urun değişkenine atıyoruz
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault(); // a burada ürünü temsil ediyor
                        UrunGetirListeye(urun, barkod, Convert.ToDouble(tMiktar.Text));
                    }
                    else // if blokunda barkod arıyor
                    // yoksa else blokuna giriyor ve teraziyi kontrol ediyor
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a=> a.TeraziOnEk==onek))
                        {
                            string teraziUrunNo = barkod.Substring(2, 5);
                            if (db.Urun.Any(a=> a.Barkod==teraziUrunNo))
                            {
                                var urunTerazi = db.Urun.Where(a => a.Barkod == teraziUrunNo).FirstOrDefault();
                                double miktarKg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListeye(urunTerazi, teraziUrunNo, miktarKg);
                            }
                            else
                            {
                                Console.Beep(900, 2000);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");
                            }
                        }
                        else
                        {
                            Console.Beep(900, 2000);
                            fUrunGirisEkrani f = new fUrunGirisEkrani(); // ürün giriş ekranı açılacak
                            f.tBarkod.Text = barkod;
                            f.ShowDialog();
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();
                
            }
        }

        private void UrunGetirListeye(Urun urun, string barkod,double miktar)
        {
            int satirSayisi = gridSatisListesi.Rows.Count;
            //double miktar = Convert.ToDouble(tMiktar.Text);
            bool eklenmisMi = false; // bu kısmı kontrol edeceğiz ve ona göre devam edeceğiz
            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                        // burada Math.Round metodunu para birimimizde virgülden sonra 2 basamak olduğu için kullanıyoruz.
                        // Math.Round(deger,sayi) olarak çalışır yani sayiden sonrasını yuvarlıyorr
                        // bizim değerimiz toplam ve miktarın çarpımı olduğundan o şekilde yazdık
                        gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmisMi = true;
                    }
                }
            }
            if (!eklenmisMi)
            {
                gridSatisListesi.Rows.Add(); // ilk aşamada satır olmadığından satır ekliyoruz
                gridSatisListesi.Rows[satirSayisi].Cells["Barkod"].Value = barkod;
                gridSatisListesi.Rows[satirSayisi].Cells["UrunAd"].Value = urun.UrunAd;
                gridSatisListesi.Rows[satirSayisi].Cells["urunGrup"].Value = urun.UrunGrup;
                gridSatisListesi.Rows[satirSayisi].Cells["Birim"].Value = urun.Birim;
                gridSatisListesi.Rows[satirSayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                gridSatisListesi.Rows[satirSayisi].Cells["Miktar"].Value = miktar;
                gridSatisListesi.Rows[satirSayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridSatisListesi.Rows[satirSayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                gridSatisListesi.Rows[satirSayisi].Cells["KdvTutari"].Value = urun.KdvTutari;
            }
        }

        private void GenelToplam()
        {
                double toplam = 0;
                for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value);
                }
                tGenelToplam.Text = toplam.ToString("C2");
                tMiktar.Text = "1";
                tBarkod.Clear();
                tBarkod.Focus();
        }

        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==9)
            {
                gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow);
                gridSatisListesi.ClearSelection();
                GenelToplam();
                tBarkod.Focus();
            }
        }

        private void bh_MouseDown(object sender,MouseEventArgs e) // tek bir metotla bütün butonların mouse down olayını aktarmış olacağız
        {
            if (e.Button==MouseButtons.Right)
            {
                Button b = (Button)sender; // geelecek olan nesnemiz buton olacak ve b değişkenine atanacak
                if (!b.Text.StartsWith("-")) // içinde ürün var yani
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No: " + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt32(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bH" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void bNx_Click(object sender, EventArgs e) // bnx bnumatatorx
        {
            Button b = (Button)sender;
            if (b.Text==",")
            {
                int virgul = tNumarator.Text.Count(x => x == ',');
                if (virgul<1)
                {
                    tNumarator.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (tNumarator.Text.Length>0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                }
            }
            else
            {
                tNumarator.Text += b.Text;
            }
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                tMiktar.Text = tNumarator.Text;
                tNumarator.Clear();
                tBarkod.Clear();
                tBarkod.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text!="")
            {
                double sonuc = Islemler.DoubleYap(tNumarator.Text) - Islemler.DoubleYap(tGenelToplam.Text);
                tParaUstu.Text = sonuc.ToString("C2");
                tOdenen.Text = Islemler.DoubleYap(tNumarator.Text).ToString("C2");
                tNumarator.Clear();
                tBarkod.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {

        }

        private void ParaUstuHesapla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = Islemler.DoubleYap(b.Text) - Islemler.DoubleYap(tGenelToplam.Text);
            tOdenen.Text = Islemler.DoubleYap(b.Text).ToString("C2");
            tParaUstu.Text = sonuc.ToString("C2");
        }

        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text!="")
            {
                int satirsayisi = gridSatisListesi.Rows.Count;
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAd"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                gridSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(tNumarator.Text);
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(tNumarator.Text);
                tNumarator.Text = "";
                GenelToplam();
                tBarkod.Focus();
            }
        }

        private void bIade_Click(object sender, EventArgs e)
        {
            if (chSatisIadeİslemi.Checked)
            {
                chSatisIadeİslemi.Checked = false;
                chSatisIadeİslemi.Text = "Satış Yapılıyor..";
            }
            else
            {
                chSatisIadeİslemi.Checked = true;
                chSatisIadeİslemi.Text = "İade işlemi yapılıyor..";
            }
        }

        private void Temizle()
        {
            tMiktar.Text="1";
            tBarkod.Clear();
            tOdenen.Clear();
            tParaUstu.Clear();
            tGenelToplam.Text = 0.ToString("C2");
            tNumarator.Clear();
            gridSatisListesi.Rows.Clear();
            tBarkod.Clear();
            tBarkod.Focus();
        }
        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public void SatisYap(string odemesekli)
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            bool satisIade = chSatisIadeİslemi.Checked;
            double alisFiyatToplam = 0;
            if (satirsayisi>0)
            {
                int? islemNo = db.Islem.First().IslemNo;
                Satis satis = new Satis();
                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.IslemNo = islemNo;
                    satis.UrunAd = gridSatisListesi.Rows[i].Cells["UrunAd"].Value.ToString();
                    satis.UrunGrup= gridSatisListesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = gridSatisListesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.SatisFiyat = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KdvTutari = Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["KdvTutari"].Value.ToString()) * Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.OdemeSekli = odemesekli;
                    satis.Iade = satisIade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lKullanici.Text;
                    db.Satis.Add(satis);
                    db.SaveChanges();
                    
                    if (!satisIade)
                    {
                        Islemler.StokAzalt(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    else
                    {
                        Islemler.StokArttir(gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["Miktar"].Value.ToString()));
                    }

                    alisFiyatToplam += Islemler.DoubleYap(gridSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString());

                }

                IslemOzet io = new IslemOzet();
                io.IslemNo = islemNo;
                io.Iade = satisIade;
                io.AlisFiyatToplam = alisFiyatToplam;
                io.Gelir = false;
                io.Gider = false;
                if (!satisIade)
                {
                    io.Aciklama = odemesekli + "Satış";
                }
                else
                {
                    io.Aciklama = "İade İşlemi (" + odemesekli + ") ile gerçekleşti.";
                }

                io.OdemeSekli = odemesekli;
                io.Kullanici = lKullanici.Text;
                io.Tarih = DateTime.Now;

                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakit = Islemler.DoubleYap(tGenelToplam.Text);
                        io.Kart = 0; break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = Islemler.DoubleYap(tGenelToplam.Text); break;
                    case "Kart-Nakit":
                        io.Nakit = Islemler.DoubleYap(lNakit.Text);
                        io.Kart = Islemler.DoubleYap(lKart.Text); break;
                }
                db.IslemOzet.Add(io);
                db.SaveChanges();

                var islemNoArttir = db.Islem.First();
                islemNoArttir.IslemNo += 1;
                db.SaveChanges();
                MessageBox.Show("Yazdırma işlemi yap");
                Temizle();
            }
        }

        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }

        private void bKart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
        }

        private void bKartNakit_Click(object sender, EventArgs e)
        {
            fNakitKart f = new fNakitKart();
            f.ShowDialog();
        }

        private void tBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) // harfleri algılamamsı için ve backspace için
            {
                e.Handled = true;
            }
        }

        private void tMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) // harfleri algılamamsı için ve backspace için
            {
                e.Handled = true;
            }
        }

        private void tNumarator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) // harfleri algılamamsı için ve backspace için
            {
                e.Handled = true;
            }
        }

        private void fSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F1)
                SatisYap("Nakit");
            if (e.KeyCode == Keys.F2)
                SatisYap("Kart");
            if (e.KeyCode == Keys.F3)
            {
                fNakitKart f = new fNakitKart();
                f.ShowDialog();
            }
        }

        private void bIslemBeklet_Click(object sender, EventArgs e)
        {
            if (bIslemBeklet.Text=="İşlem Beklet")
            {
                Bekle();
                bIslemBeklet.BackColor = System.Drawing.Color.OrangeRed;
                bIslemBeklet.Text = "İşlem Beklemede";
                gridSatisListesi.Rows.Clear();
            }
            else
            {
                BeklemedenCik();
                bIslemBeklet.BackColor = System.Drawing.SystemColors.GrayText;
                bIslemBeklet.Text = "İşlem Beklet";
                gridBekle.Rows.Clear();
            }
            
        }

        private void Bekle()
        {
            int satir = gridSatisListesi.Rows.Count;
            int sutun = gridSatisListesi.Columns.Count;
            if (satir>0)
            {
                for (int i = 0; i < satir; i++)
                {
                    gridBekle.Rows.Add();
                    for (int j = 0; j < sutun-1; j++) // sil butonu olduğu için -1
                    {
                        gridBekle.Rows[i].Cells[j].Value = gridSatisListesi.Rows[i].Cells[j].Value;
                    }
                }
            }
        }

        private void BeklemedenCik()
        {
            int satir = gridBekle.Rows.Count;
            int sutun = gridBekle.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    gridSatisListesi.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++) // sil butonu olduğu için -1
                    {
                        gridSatisListesi.Rows[i].Cells[j].Value = gridBekle.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
    }
}
