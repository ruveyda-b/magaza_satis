
namespace magaza_satis
{
    partial class fStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitCGenel = new System.Windows.Forms.SplitContainer();
            this.panelIslemTuru = new System.Windows.Forms.Panel();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.panelUrunGrubu = new System.Windows.Forms.Panel();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panelFiltrelemeTuru = new System.Windows.Forms.Panel();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.splitCUrunGrid = new System.Windows.Forms.SplitContainer();
            this.lIslemTuru = new magaza_satis.lStandart();
            this.bAra = new magaza_satis.bStandart();
            this.lStandart2 = new magaza_satis.lStandart();
            this.lStandart1 = new magaza_satis.lStandart();
            this.lUrunGrubu = new magaza_satis.lStandart();
            this.lFiltrelemeTuru = new magaza_satis.lStandart();
            this.lKullanici = new magaza_satis.lStandart();
            this.tUrunAra = new magaza_satis.tStandart();
            this.lUrunAra = new magaza_satis.lStandart();
            this.gridListe = new magaza_satis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitCGenel)).BeginInit();
            this.splitCGenel.Panel1.SuspendLayout();
            this.splitCGenel.Panel2.SuspendLayout();
            this.splitCGenel.SuspendLayout();
            this.panelIslemTuru.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            this.panelUrunGrubu.SuspendLayout();
            this.panelFiltrelemeTuru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCUrunGrid)).BeginInit();
            this.splitCUrunGrid.Panel1.SuspendLayout();
            this.splitCUrunGrid.Panel2.SuspendLayout();
            this.splitCUrunGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitCGenel
            // 
            this.splitCGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCGenel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCGenel.Location = new System.Drawing.Point(0, 0);
            this.splitCGenel.Margin = new System.Windows.Forms.Padding(0);
            this.splitCGenel.Name = "splitCGenel";
            // 
            // splitCGenel.Panel1
            // 
            this.splitCGenel.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitCGenel.Panel1.Controls.Add(this.panelIslemTuru);
            this.splitCGenel.Panel1.Controls.Add(this.bAra);
            this.splitCGenel.Panel1.Controls.Add(this.panelTarihler);
            this.splitCGenel.Panel1.Controls.Add(this.panelUrunGrubu);
            this.splitCGenel.Panel1.Controls.Add(this.panelFiltrelemeTuru);
            // 
            // splitCGenel.Panel2
            // 
            this.splitCGenel.Panel2.Controls.Add(this.splitCUrunGrid);
            this.splitCGenel.Size = new System.Drawing.Size(1322, 670);
            this.splitCGenel.SplitterDistance = 315;
            this.splitCGenel.TabIndex = 0;
            // 
            // panelIslemTuru
            // 
            this.panelIslemTuru.Controls.Add(this.cmbIslemTuru);
            this.panelIslemTuru.Controls.Add(this.lIslemTuru);
            this.panelIslemTuru.Location = new System.Drawing.Point(2, 4);
            this.panelIslemTuru.Margin = new System.Windows.Forms.Padding(2);
            this.panelIslemTuru.Name = "panelIslemTuru";
            this.panelIslemTuru.Size = new System.Drawing.Size(309, 87);
            this.panelIslemTuru.TabIndex = 0;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(2, 37);
            this.cmbIslemTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(222, 28);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dateBitis);
            this.panelTarihler.Controls.Add(this.lStandart2);
            this.panelTarihler.Controls.Add(this.dateBaslangic);
            this.panelTarihler.Controls.Add(this.lStandart1);
            this.panelTarihler.Location = new System.Drawing.Point(2, 280);
            this.panelTarihler.Margin = new System.Windows.Forms.Padding(2);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(309, 162);
            this.panelTarihler.TabIndex = 7;
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Location = new System.Drawing.Point(6, 102);
            this.dateBitis.Margin = new System.Windows.Forms.Padding(2);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(289, 30);
            this.dateBitis.TabIndex = 2;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(7, 41);
            this.dateBaslangic.Margin = new System.Windows.Forms.Padding(2);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(289, 30);
            this.dateBaslangic.TabIndex = 0;
            // 
            // panelUrunGrubu
            // 
            this.panelUrunGrubu.Controls.Add(this.lUrunGrubu);
            this.panelUrunGrubu.Controls.Add(this.cmbUrunGrubu);
            this.panelUrunGrubu.Location = new System.Drawing.Point(4, 194);
            this.panelUrunGrubu.Margin = new System.Windows.Forms.Padding(2);
            this.panelUrunGrubu.Name = "panelUrunGrubu";
            this.panelUrunGrubu.Size = new System.Drawing.Size(306, 100);
            this.panelUrunGrubu.TabIndex = 6;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(2, 34);
            this.cmbUrunGrubu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(221, 28);
            this.cmbUrunGrubu.TabIndex = 5;
            // 
            // panelFiltrelemeTuru
            // 
            this.panelFiltrelemeTuru.Controls.Add(this.rdUrunGrubunaGore);
            this.panelFiltrelemeTuru.Controls.Add(this.lFiltrelemeTuru);
            this.panelFiltrelemeTuru.Controls.Add(this.rdTumu);
            this.panelFiltrelemeTuru.Location = new System.Drawing.Point(2, 80);
            this.panelFiltrelemeTuru.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiltrelemeTuru.Name = "panelFiltrelemeTuru";
            this.panelFiltrelemeTuru.Size = new System.Drawing.Size(309, 135);
            this.panelFiltrelemeTuru.TabIndex = 4;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdUrunGrubunaGore.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(2, 68);
            this.rdUrunGrubunaGore.Margin = new System.Windows.Forms.Padding(2);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(169, 24);
            this.rdUrunGrubunaGore.TabIndex = 4;
            this.rdUrunGrubunaGore.TabStop = true;
            this.rdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdTumu.Location = new System.Drawing.Point(2, 40);
            this.rdTumu.Margin = new System.Windows.Forms.Padding(2);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(67, 24);
            this.rdTumu.TabIndex = 3;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // splitCUrunGrid
            // 
            this.splitCUrunGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCUrunGrid.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCUrunGrid.Location = new System.Drawing.Point(0, 0);
            this.splitCUrunGrid.Margin = new System.Windows.Forms.Padding(0);
            this.splitCUrunGrid.Name = "splitCUrunGrid";
            this.splitCUrunGrid.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCUrunGrid.Panel1
            // 
            this.splitCUrunGrid.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitCUrunGrid.Panel1.Controls.Add(this.lKullanici);
            this.splitCUrunGrid.Panel1.Controls.Add(this.tUrunAra);
            this.splitCUrunGrid.Panel1.Controls.Add(this.lUrunAra);
            // 
            // splitCUrunGrid.Panel2
            // 
            this.splitCUrunGrid.Panel2.Controls.Add(this.gridListe);
            this.splitCUrunGrid.Size = new System.Drawing.Size(1003, 670);
            this.splitCUrunGrid.SplitterDistance = 71;
            this.splitCUrunGrid.TabIndex = 0;
            // 
            // lIslemTuru
            // 
            this.lIslemTuru.AutoSize = true;
            this.lIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lIslemTuru.ForeColor = System.Drawing.Color.OrangeRed;
            this.lIslemTuru.Location = new System.Drawing.Point(6, 17);
            this.lIslemTuru.Name = "lIslemTuru";
            this.lIslemTuru.Size = new System.Drawing.Size(104, 25);
            this.lIslemTuru.TabIndex = 0;
            this.lIslemTuru.Text = "İşlem Türü";
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.Color.White;
            this.bAra.Location = new System.Drawing.Point(177, 522);
            this.bAra.Margin = new System.Windows.Forms.Padding(0);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(135, 86);
            this.bAra.TabIndex = 0;
            this.bAra.Text = "Ara";
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lStandart2.Location = new System.Drawing.Point(3, 88);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(102, 25);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Bitiş Tarihi";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lStandart1.Location = new System.Drawing.Point(3, 12);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(151, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Başlangıç Tarihi";
            // 
            // lUrunGrubu
            // 
            this.lUrunGrubu.AutoSize = true;
            this.lUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunGrubu.ForeColor = System.Drawing.Color.OrangeRed;
            this.lUrunGrubu.Location = new System.Drawing.Point(7, 14);
            this.lUrunGrubu.Name = "lUrunGrubu";
            this.lUrunGrubu.Size = new System.Drawing.Size(113, 25);
            this.lUrunGrubu.TabIndex = 6;
            this.lUrunGrubu.Text = "Ürün Grubu";
            // 
            // lFiltrelemeTuru
            // 
            this.lFiltrelemeTuru.AutoSize = true;
            this.lFiltrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lFiltrelemeTuru.ForeColor = System.Drawing.Color.OrangeRed;
            this.lFiltrelemeTuru.Location = new System.Drawing.Point(3, 11);
            this.lFiltrelemeTuru.Name = "lFiltrelemeTuru";
            this.lFiltrelemeTuru.Size = new System.Drawing.Size(142, 25);
            this.lFiltrelemeTuru.TabIndex = 2;
            this.lFiltrelemeTuru.Text = "Filtreleme Türü";
            // 
            // lKullanici
            // 
            this.lKullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(581, 18);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(83, 20);
            this.lKullanici.TabIndex = 2;
            this.lKullanici.Text = "lStandart3";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(99, 23);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(291, 26);
            this.tUrunAra.TabIndex = 1;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lUrunAra
            // 
            this.lUrunAra.AutoSize = true;
            this.lUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunAra.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunAra.Location = new System.Drawing.Point(2, 19);
            this.lUrunAra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUrunAra.Name = "lUrunAra";
            this.lUrunAra.Size = new System.Drawing.Size(73, 20);
            this.lUrunAra.TabIndex = 0;
            this.lUrunAra.Text = "Ürün Ara";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowHeadersWidth = 51;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridListe.RowTemplate.Height = 30;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(1003, 595);
            this.gridListe.TabIndex = 1;
            this.gridListe.TabStop = false;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(992, 544);
            this.Controls.Add(this.splitCGenel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fStok";
            this.Text = "Stok İzleme";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitCGenel.Panel1.ResumeLayout(false);
            this.splitCGenel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCGenel)).EndInit();
            this.splitCGenel.ResumeLayout(false);
            this.panelIslemTuru.ResumeLayout(false);
            this.panelIslemTuru.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.panelUrunGrubu.ResumeLayout(false);
            this.panelUrunGrubu.PerformLayout();
            this.panelFiltrelemeTuru.ResumeLayout(false);
            this.panelFiltrelemeTuru.PerformLayout();
            this.splitCUrunGrid.Panel1.ResumeLayout(false);
            this.splitCUrunGrid.Panel1.PerformLayout();
            this.splitCUrunGrid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCUrunGrid)).EndInit();
            this.splitCUrunGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCGenel;
        private System.Windows.Forms.Panel panelFiltrelemeTuru;
        private System.Windows.Forms.RadioButton rdTumu;
        private lStandart lFiltrelemeTuru;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private lStandart lIslemTuru;
        private System.Windows.Forms.RadioButton rdUrunGrubunaGore;
        private System.Windows.Forms.Panel panelUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private lStandart lUrunGrubu;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private lStandart lStandart2;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private lStandart lStandart1;
        private bStandart bAra;
        private System.Windows.Forms.Panel panelIslemTuru;
        private System.Windows.Forms.SplitContainer splitCUrunGrid;
        private tStandart tUrunAra;
        private lStandart lUrunAra;
        private gridOzel gridListe;
        internal lStandart lKullanici;
    }
}