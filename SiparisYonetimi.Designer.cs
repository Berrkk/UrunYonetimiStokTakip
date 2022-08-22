
namespace ÜrunYönetimiStokTakip
{
    partial class SiparisYonetimi
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
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 12);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(364, 561);
            this.dgvSiparisler.TabIndex = 0;
            this.dgvSiparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.dtpSiparisTarihi);
            this.groupBox1.Controls.Add(this.cbUrunler);
            this.groupBox1.Controls.Add(this.cbMusteriler);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtSiparisNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(399, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(24, 168);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "0";
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(132, 130);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpSiparisTarihi.TabIndex = 15;
            // 
            // cbUrunler
            // 
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(132, 90);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(121, 21);
            this.cbUrunler.TabIndex = 14;
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(132, 53);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(121, 21);
            this.cbMusteriler.TabIndex = 13;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(241, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(143, 184);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(49, 184);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(132, 19);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(100, 20);
            this.txtSiparisNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sipariş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş No";
            // 
            // SiparisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "SiparisYonetimi";
            this.Text = "SiparisYonetimi";
            this.Load += new System.EventHandler(this.SiparisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSiparisNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.ComboBox cbMusteriler;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.Label lblId;
    }
}