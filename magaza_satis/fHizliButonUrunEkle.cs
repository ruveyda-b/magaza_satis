﻿using System;
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
    public partial class fHizliButonUrunEkle : Form
    {
        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        BarkodDbEntities db = new BarkodDbEntities();
        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text!="")
            {
                string urunad = tUrunAra.Text;
                var urunler = db.Urun.Where(a=> a.UrunAd.Contains(urunad)).ToList();
                gridUrunler.DataSource = urunler;
                Islemler.GridDuzenle(gridUrunler);
            }
        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUrunler.Rows.Count>0)
            {
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunAd = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt32(lButonId.Text);

                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunAd;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton tanımlanmıştır.");
                fSatis f = (fSatis)Application.OpenForms["fsatis"];
                if (f!=null)
                {
                    Button b = f.Controls.Find("bH" + id,true).FirstOrDefault() as Button;
                    b.Text = urunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                gridUrunler.DataSource = db.Urun.ToList();
                gridUrunler.Columns["AlisFiyat"].Visible = false;
                gridUrunler.Columns["SatisFiyat"].Visible = false;
                gridUrunler.Columns["KdvOrani"].Visible = false;
                gridUrunler.Columns["KdvTutari"].Visible = false;
                gridUrunler.Columns["Miktar"].Visible = false;

                Islemler.GridDuzenle(gridUrunler);
            }
            else
            {
                gridUrunler.DataSource = null;
            }
        }
    }
}
