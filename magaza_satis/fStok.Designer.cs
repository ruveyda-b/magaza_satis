﻿
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
            this.lIslemTuru = new magaza_satis.lStandart();
            this.bAra = new magaza_satis.bStandart();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.lStandart2 = new magaza_satis.lStandart();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lStandart1 = new magaza_satis.lStandart();
            this.panelUrunGrubu = new System.Windows.Forms.Panel();
            this.lUrunGrubu = new magaza_satis.lStandart();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panelFiltrelemeTuru = new System.Windows.Forms.Panel();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.lFiltrelemeTuru = new magaza_satis.lStandart();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.splitCUrunGrid = new System.Windows.Forms.SplitContainer();
            this.tUrunAra = new magaza_satis.tStandart();
            this.lUrunAra = new magaza_satis.lStandart();
            this.gridUrunler = new magaza_satis.gridOzel();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitCGenel
            // 
            this.splitCGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCGenel.Location = new System.Drawing.Point(0, 0);
            this.splitCGenel.Name = "splitCGenel";
            // 
            // splitCGenel.Panel1
            // 
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
            this.splitCGenel.SplitterDistance = 361;
            this.splitCGenel.TabIndex = 0;
            // 
            // panelIslemTuru
            // 
            this.panelIslemTuru.Controls.Add(this.cmbIslemTuru);
            this.panelIslemTuru.Controls.Add(this.lIslemTuru);
            this.panelIslemTuru.Location = new System.Drawing.Point(3, 5);
            this.panelIslemTuru.Name = "panelIslemTuru";
            this.panelIslemTuru.Size = new System.Drawing.Size(352, 87);
            this.panelIslemTuru.TabIndex = 0;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(3, 45);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(294, 33);
            this.cmbIslemTuru.TabIndex = 1;
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
            this.bAra.Location = new System.Drawing.Point(220, 520);
            this.bAra.Margin = new System.Windows.Forms.Padding(0);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(135, 86);
            this.bAra.TabIndex = 0;
            this.bAra.Text = "Ara";
            this.bAra.UseVisualStyleBackColor = false;
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dateBitis);
            this.panelTarihler.Controls.Add(this.lStandart2);
            this.panelTarihler.Controls.Add(this.dateBaslangic);
            this.panelTarihler.Controls.Add(this.lStandart1);
            this.panelTarihler.Location = new System.Drawing.Point(3, 345);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(352, 162);
            this.panelTarihler.TabIndex = 7;
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitis.Location = new System.Drawing.Point(8, 125);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 30);
            this.dateBitis.TabIndex = 2;
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
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(9, 50);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(200, 30);
            this.dateBaslangic.TabIndex = 0;
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
            // panelUrunGrubu
            // 
            this.panelUrunGrubu.Controls.Add(this.lUrunGrubu);
            this.panelUrunGrubu.Controls.Add(this.cmbUrunGrubu);
            this.panelUrunGrubu.Location = new System.Drawing.Point(6, 239);
            this.panelUrunGrubu.Name = "panelUrunGrubu";
            this.panelUrunGrubu.Size = new System.Drawing.Size(355, 100);
            this.panelUrunGrubu.TabIndex = 6;
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
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(2, 42);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(293, 33);
            this.cmbUrunGrubu.TabIndex = 5;
            // 
            // panelFiltrelemeTuru
            // 
            this.panelFiltrelemeTuru.Controls.Add(this.rdUrunGrubunaGore);
            this.panelFiltrelemeTuru.Controls.Add(this.lFiltrelemeTuru);
            this.panelFiltrelemeTuru.Controls.Add(this.rdTumu);
            this.panelFiltrelemeTuru.Location = new System.Drawing.Point(3, 98);
            this.panelFiltrelemeTuru.Name = "panelFiltrelemeTuru";
            this.panelFiltrelemeTuru.Size = new System.Drawing.Size(355, 135);
            this.panelFiltrelemeTuru.TabIndex = 4;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdUrunGrubunaGore.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(3, 84);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(204, 29);
            this.rdUrunGrubunaGore.TabIndex = 4;
            this.rdUrunGrubunaGore.TabStop = true;
            this.rdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
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
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.rdTumu.Location = new System.Drawing.Point(3, 49);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(84, 29);
            this.rdTumu.TabIndex = 3;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            this.rdTumu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // splitCUrunGrid
            // 
            this.splitCUrunGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCUrunGrid.Location = new System.Drawing.Point(0, 0);
            this.splitCUrunGrid.Name = "splitCUrunGrid";
            this.splitCUrunGrid.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCUrunGrid.Panel1
            // 
            this.splitCUrunGrid.Panel1.Controls.Add(this.tUrunAra);
            this.splitCUrunGrid.Panel1.Controls.Add(this.lUrunAra);
            // 
            // splitCUrunGrid.Panel2
            // 
            this.splitCUrunGrid.Panel2.Controls.Add(this.gridUrunler);
            this.splitCUrunGrid.Size = new System.Drawing.Size(957, 670);
            this.splitCUrunGrid.SplitterDistance = 72;
            this.splitCUrunGrid.TabIndex = 0;
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(100, 24);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(387, 30);
            this.tUrunAra.TabIndex = 1;
            // 
            // lUrunAra
            // 
            this.lUrunAra.AutoSize = true;
            this.lUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunAra.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunAra.Location = new System.Drawing.Point(3, 23);
            this.lUrunAra.Name = "lUrunAra";
            this.lUrunAra.Size = new System.Drawing.Size(90, 25);
            this.lUrunAra.TabIndex = 0;
            this.lUrunAra.Text = "Ürün Ara";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.RowHeadersWidth = 51;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUrunler.RowTemplate.Height = 30;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(957, 594);
            this.gridUrunler.TabIndex = 1;
            this.gridUrunler.TabStop = false;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1322, 670);
            this.Controls.Add(this.splitCGenel);
            this.Name = "fStok";
            this.Text = "Stok İzleme";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
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
        private gridOzel gridUrunler;
    }
}