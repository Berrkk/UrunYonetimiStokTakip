
namespace ÜrunYönetimiStokTakip
{
    partial class UrunYönetimi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürümYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUrunMarkası = new System.Windows.Forms.ComboBox();
            this.cbUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbUrunAcıklaması = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblEklemeTarihi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.markaYönetimiToolStripMenuItem,
            this.ürümYönetimiToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // markaYönetimiToolStripMenuItem
            // 
            this.markaYönetimiToolStripMenuItem.Name = "markaYönetimiToolStripMenuItem";
            this.markaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.markaYönetimiToolStripMenuItem.Text = "Marka Yönetimi";
            // 
            // ürümYönetimiToolStripMenuItem
            // 
            this.ürümYönetimiToolStripMenuItem.Name = "ürümYönetimiToolStripMenuItem";
            this.ürümYönetimiToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.ürümYönetimiToolStripMenuItem.Text = "Ürüm Yönetimi";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtIskonto);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbUrunMarkası);
            this.groupBox1.Controls.Add(this.cbUrunKategorisi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtStokMiktari);
            this.groupBox1.Controls.Add(this.txtKDV);
            this.groupBox1.Controls.Add(this.txtUrunFiyati);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtbUrunAcıklaması);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.lblEklemeTarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(984, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 484);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Yönetimi";
            // 
            // cbUrunMarkası
            // 
            this.cbUrunMarkası.DisplayMember = "MarkaAdi";
            this.cbUrunMarkası.FormattingEnabled = true;
            this.cbUrunMarkası.Location = new System.Drawing.Point(105, 327);
            this.cbUrunMarkası.Name = "cbUrunMarkası";
            this.cbUrunMarkası.Size = new System.Drawing.Size(121, 21);
            this.cbUrunMarkası.TabIndex = 21;
            this.cbUrunMarkası.ValueMember = "Id";
            // 
            // cbUrunKategorisi
            // 
            this.cbUrunKategorisi.DisplayMember = "KategoriAdi";
            this.cbUrunKategorisi.FormattingEnabled = true;
            this.cbUrunKategorisi.Location = new System.Drawing.Point(105, 292);
            this.cbUrunKategorisi.Name = "cbUrunKategorisi";
            this.cbUrunKategorisi.Size = new System.Drawing.Size(121, 21);
            this.cbUrunKategorisi.TabIndex = 20;
            this.cbUrunKategorisi.ValueMember = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ürün Markası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ürün Kategorisi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Aktif/pasif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stok Miktari";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(116, 237);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtStokMiktari.TabIndex = 15;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(116, 200);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(100, 20);
            this.txtKDV.TabIndex = 14;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(116, 161);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyati.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "KDV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // rtbUrunAcıklaması
            // 
            this.rtbUrunAcıklaması.Location = new System.Drawing.Point(116, 46);
            this.rtbUrunAcıklaması.Name = "rtbUrunAcıklaması";
            this.rtbUrunAcıklaması.Size = new System.Drawing.Size(100, 96);
            this.rtbUrunAcıklaması.TabIndex = 9;
            this.rtbUrunAcıklaması.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(197, 419);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(116, 419);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(35, 419);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(116, 263);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(57, 17);
            this.cbDurum.TabIndex = 5;
            this.cbDurum.Text = "Durum";
            this.cbDurum.UseVisualStyleBackColor = true;
            this.cbDurum.CheckedChanged += new System.EventHandler(this.cbDurum_CheckedChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(116, 30);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // lblEklemeTarihi
            // 
            this.lblEklemeTarihi.AutoSize = true;
            this.lblEklemeTarihi.Location = new System.Drawing.Point(11, 387);
            this.lblEklemeTarihi.Name = "lblEklemeTarihi";
            this.lblEklemeTarihi.Size = new System.Drawing.Size(77, 13);
            this.lblEklemeTarihi.TabIndex = 2;
            this.lblEklemeTarihi.Text = "Eklenme Tarihi";
            this.lblEklemeTarihi.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 27);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(966, 509);
            this.dgvUrunler.TabIndex = 6;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "İskonto";
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(105, 364);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(100, 20);
            this.txtIskonto.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(178, 387);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "0";
            // 
            // UrunYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 588);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UrunYönetimi";
            this.Text = "UrunYönetimi";
            this.Load += new System.EventHandler(this.UrunYönetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürümYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblEklemeTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.RichTextBox rtbUrunAcıklaması;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUrunMarkası;
        private System.Windows.Forms.ComboBox cbUrunKategorisi;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
    }
}