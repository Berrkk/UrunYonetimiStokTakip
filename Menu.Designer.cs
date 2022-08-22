
namespace ÜrunYönetimiStokTakip
{
    partial class Menu
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
            this.btnKategoriYonetimi = new System.Windows.Forms.Button();
            this.btnKullanıcıYonetimi = new System.Windows.Forms.Button();
            this.btnMarkaYonetimi = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnSiparisYönetimi = new System.Windows.Forms.Button();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriYonetimi
            // 
            this.btnKategoriYonetimi.Location = new System.Drawing.Point(88, 117);
            this.btnKategoriYonetimi.Name = "btnKategoriYonetimi";
            this.btnKategoriYonetimi.Size = new System.Drawing.Size(108, 75);
            this.btnKategoriYonetimi.TabIndex = 0;
            this.btnKategoriYonetimi.Text = "Kategori yönetimi";
            this.btnKategoriYonetimi.UseVisualStyleBackColor = true;
            this.btnKategoriYonetimi.Click += new System.EventHandler(this.btnKategoriYonetimi_Click);
            // 
            // btnKullanıcıYonetimi
            // 
            this.btnKullanıcıYonetimi.Location = new System.Drawing.Point(88, 247);
            this.btnKullanıcıYonetimi.Name = "btnKullanıcıYonetimi";
            this.btnKullanıcıYonetimi.Size = new System.Drawing.Size(108, 77);
            this.btnKullanıcıYonetimi.TabIndex = 1;
            this.btnKullanıcıYonetimi.Text = "Kullanıcı Yönetimi";
            this.btnKullanıcıYonetimi.UseVisualStyleBackColor = true;
            this.btnKullanıcıYonetimi.Click += new System.EventHandler(this.btnKullanıcıYonetimi_Click);
            // 
            // btnMarkaYonetimi
            // 
            this.btnMarkaYonetimi.Location = new System.Drawing.Point(266, 117);
            this.btnMarkaYonetimi.Name = "btnMarkaYonetimi";
            this.btnMarkaYonetimi.Size = new System.Drawing.Size(121, 83);
            this.btnMarkaYonetimi.TabIndex = 2;
            this.btnMarkaYonetimi.Text = "Marka Yönetimi";
            this.btnMarkaYonetimi.UseVisualStyleBackColor = true;
            this.btnMarkaYonetimi.Click += new System.EventHandler(this.btnMarkaYonetimi_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(274, 247);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(113, 77);
            this.btnMusteriYonetimi.TabIndex = 3;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnSiparisYönetimi
            // 
            this.btnSiparisYönetimi.Location = new System.Drawing.Point(428, 117);
            this.btnSiparisYönetimi.Name = "btnSiparisYönetimi";
            this.btnSiparisYönetimi.Size = new System.Drawing.Size(115, 83);
            this.btnSiparisYönetimi.TabIndex = 4;
            this.btnSiparisYönetimi.Text = "Sipariş Yönetimi";
            this.btnSiparisYönetimi.UseVisualStyleBackColor = true;
            this.btnSiparisYönetimi.Click += new System.EventHandler(this.btnSiparisYönetimi_Click);
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.Location = new System.Drawing.Point(428, 247);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(115, 77);
            this.btnUrunYonetimi.TabIndex = 5;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 590);
            this.Controls.Add(this.btnUrunYonetimi);
            this.Controls.Add(this.btnSiparisYönetimi);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnMarkaYonetimi);
            this.Controls.Add(this.btnKullanıcıYonetimi);
            this.Controls.Add(this.btnKategoriYonetimi);
            this.Name = "Menü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.Menü_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriYonetimi;
        private System.Windows.Forms.Button btnKullanıcıYonetimi;
        private System.Windows.Forms.Button btnMarkaYonetimi;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnSiparisYönetimi;
        private System.Windows.Forms.Button btnUrunYonetimi;
    }
}