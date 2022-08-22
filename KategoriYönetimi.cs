using BL;
using Entities;
using System;
using System.Windows.Forms;

namespace ÜrunYönetimiStokTakip
{
    public partial class KategoriYönetimi : Form
    {
        public KategoriYönetimi()

        {
            InitializeComponent();
        }
        KategoriManager manager = new KategoriManager();
        void Yukle()
        {
            dgvKategoriler.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtKategoriAdi.Text = string.Empty;
            txtKategoriAcıklama.Text = string.Empty;
            lblEklenmeTarihi.Text = string.Empty;
            lblId.Text = "0";
            cbDurum.Checked = false;
        }

        private void KategoriYönetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Kategori
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklamasi = txtKategoriAcıklama.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now
                }
                );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception hata) //buradaki hata nesnesinden hata detaylarına ulaşabiliriz
            {
                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!n\\Boş Alan Bırakmadan Tekrar Deneyin!" + hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Update(
                new Kategori
                {
                   Id=int.Parse(lblId.Text),
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklamasi = txtKategoriAcıklama.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text)
                }
                );
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi!");
                }
            }
            catch (Exception hata) //buradaki hata nesnesinden hata detaylarına ulaşabiliriz
            {
                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi!n\\Boş Alan Bırakmadan Tekrar Deneyin!");
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

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvKategoriler.CurrentRow.Cells[0].Value.ToString();
                txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
                if (dgvKategoriler.CurrentRow.Cells[2].Value != null) txtKategoriAcıklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
                lblEklenmeTarihi.Text = dgvKategoriler.CurrentRow.Cells[3].Value.ToString();
                cbDurum.Checked = Convert.ToBoolean(dgvKategoriler.CurrentRow.Cells[4].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Atanırken Hata Oluştu!");
            }
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYönetimi markaYonetimi = new MarkaYönetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void ürümYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                UrunYönetimi urunYonetimi = new UrunYönetimi();
                this.Close();
                urunYonetimi.ShowDialog();
            }
        }
    }
}
