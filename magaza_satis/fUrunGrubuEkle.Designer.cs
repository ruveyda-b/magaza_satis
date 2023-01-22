
namespace magaza_satis
{
    partial class fUrunGrubuEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lUrunGrubuAdi = new magaza_satis.lStandart();
            this.tUrunGrupAd = new magaza_satis.tStandart();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.bEkle = new magaza_satis.bStandart();
            this.bSil = new magaza_satis.bStandart();
            this.SuspendLayout();
            // 
            // lUrunGrubuAdi
            // 
            this.lUrunGrubuAdi.AutoSize = true;
            this.lUrunGrubuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunGrubuAdi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunGrubuAdi.Location = new System.Drawing.Point(13, 22);
            this.lUrunGrubuAdi.Name = "lUrunGrubuAdi";
            this.lUrunGrubuAdi.Size = new System.Drawing.Size(147, 25);
            this.lUrunGrubuAdi.TabIndex = 0;
            this.lUrunGrubuAdi.Text = "Ürün Grubu Adı";
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(18, 51);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(402, 30);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 25;
            this.listUrunGrup.Location = new System.Drawing.Point(18, 101);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(402, 279);
            this.listUrunGrup.TabIndex = 2;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.BlueViolet;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Location = new System.Drawing.Point(232, 398);
            this.bEkle.Margin = new System.Windows.Forms.Padding(0);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(188, 115);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Indigo;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.Color.White;
            this.bSil.Location = new System.Drawing.Point(18, 398);
            this.bSil.Margin = new System.Windows.Forms.Padding(0);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(188, 115);
            this.bSil.TabIndex = 3;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(475, 562);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lUrunGrubuAdi);
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lUrunGrubuAdi;
        private tStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private bStandart bEkle;
        private bStandart bSil;
    }
}