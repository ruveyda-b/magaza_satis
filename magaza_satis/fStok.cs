using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magaza_satis
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using (var db = new BarkodDbEntities())
            {
                if (cmbIslemTuru.Text!="")
                {
                    string urungrubu = cmbUrunGrubu.Text;
                    if (cmbIslemTuru.SelectedIndex==0) // stok durumuna bakıyoruz
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList(); // stok durumunu gridlistesinden arıyoruz
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türü seçiniz!");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex==1) // stok giriş izlemeye bakıyoruz
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked) // tümününe göre listeleme işlemi
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load(); // stok hareketi
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList(); // listeliyor

                        }
                        else if (rdUrunGrubunaGore.Checked) // ürüngrubuna göre listeleme işlemi
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Ürün Grubunu seçiniz!");

                        }
                      
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen İşlem Türü seçiniz!");
                }
            }
            Islemler.GridDuzenle(gridListe); // bu metot datagridliste mizdeki başlıkların adlarının düzenlenmesi için bunu kullanmazsam değişken adları görünür
        }
        BarkodDbEntities dbx = new BarkodDbEntities();

        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e) //içerisindeki veri değişirse
        {
            if (tUrunAra.Text.Length>=3)
            {
                string urunad = tUrunAra.Text;
                using (var db = new BarkodDbEntities())
                {
                    if (cmbIslemTuru.SelectedIndex==0) // stok durumuna bakıyoruz
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load(); // tUrunAra dan aldığımız ürünadının database de olup olmadığına bakıyoruz
                        gridListe.DataSource = db.Urun.Local.ToBindingList(); 
                    }
                    else if(cmbIslemTuru.SelectedIndex==1) // stok giriş izlemeye bakıyoruz
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load(); // yine alınan ürünadının stokhareket db sinde içerip içermediğine bakıyoruz
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(gridListe); // bu metot datagridliste mizdeki başlıkların adlarının düzenlenmesi için bunu kullanmazsam değişken adları görünür
            }
        }
    }
}
