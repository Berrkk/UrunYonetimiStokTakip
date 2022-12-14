using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrunYönetimiStokTakip
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        void Yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtKullaniciadi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyAdi.Text = string.Empty;
            cbDurum.Checked = false;
            lblId.Text = "0";
        }
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Kullanici
                    {
                        Adi = txtAdi.Text,
                        Soyadi = txtSoyAdi.Text,
                        Email = txtEmail.Text,
                        KullaniciAdi = txtKullaniciadi.Text,
                        Sifre = txtSifre.Text,
                        Aktif = cbDurum.Checked
                        
                    }
                    );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                var sonuc = manager.Update(
                    new Kullanici
                    {
                        Id = int.Parse(lblId.Text),
                        Adi = txtAdi.Text,
                        Soyadi = txtSoyAdi.Text,
                        Email = txtEmail.Text,
                        KullaniciAdi = txtKullaniciadi.Text,
                        Sifre = txtSifre.Text,
                        Aktif = cbDurum.Checked
                        
                    }
                    );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!");
            }
        }
        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvKullanicilar.CurrentRow.Cells[0].Value.ToString();
                txtKullaniciadi.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
                if (dgvKullanicilar.CurrentRow.Cells[2].Value != null) txtSifre.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
                txtAdi.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
                txtSoyAdi.Text = dgvKullanicilar.CurrentRow.Cells[5].Value.ToString();
                cbDurum.Checked = Convert.ToBoolean(dgvKullanicilar.CurrentRow.Cells[6].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Atanırken Hata Oluştu!");
            }
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
