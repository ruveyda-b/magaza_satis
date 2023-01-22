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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }

        BarkodDbEntities db = new BarkodDbEntities();

        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text!="")
            {
                UrunGrup uGrup = new UrunGrup();
                uGrup.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(uGrup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear();
                MessageBox.Show("Ürün grubu eklenmiştir.");

                fUrunGirisEkrani f = (fUrunGirisEkrani)Application.OpenForms["fUrunGirisEkrani"];
                if (f!=null)
                {
                    f.GrupDoldur();
                }

            }
            else
            {
                MessageBox.Show("Lütfen grup bilgisi ekleyiniz.");
            }
        }

        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();// orderby ile urungrup adına göre de sıralama yapacak
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + " grubunu silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupad + " ürün grubu silindi");
                fUrunGirisEkrani f = (fUrunGirisEkrani)Application.OpenForms["fUrunGirisEkrani"];
                f.GrupDoldur();
            }
        }
    }
}
