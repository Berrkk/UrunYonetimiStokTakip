using BL;
using Entities;
using System;
using System.Windows.Forms;


namespace ÜrunYönetimiStokTakip
{
    public partial class UrunYönetimi : Form
    {
        public UrunYönetimi()
        {
            InitializeComponent();
        }
        UrunManager manager = new UrunManager();
        KategoriManager kategoriManager = new KategoriManager();
        MarkaManager markaManager = new MarkaManager();
        void Yukle()
        {

            
            dgvUrunler.DataSource = manager.GetAll();
            cbUrunKategorisi.DataSource = kategoriManager.GetAll();//kategoriManager üzerindeki getall metoduyla veritabanındaki tüm kategorileri çekip cburunkategorisi ne verileri yükledik. Sonrasında design tarafından display member alanında veritabanındaki kategori tablosundan gelen veriler üzerinden KategoriAdi sütununu program kullanıcısının göreceği listede gösterdik. Ürün eklerken ise kategoriId sütununa seçilen kategorinin Id değerini atayabilmek için yine design tarafında cbUrunKategorisi ne sağ tık properties yapıp Value Member alanına Id yazıp enter a bastık ki arkayüzde seçilen kategorinin ıd sini yakalayıp Urun tablosundaki KategoriId sütununa yollayabilelim..
            cbUrunMarkası.DataSource = markaManager.GetAll(); //Markaları çekip cbUrunMarkasi na yükledik, ön yüzden Display Member a MarkaAdi, Value Member a Id yazıp enter dedik.
        }
        void Temizle()
        {
            txtIskonto.Text = string.Empty;
            txtKDV.Text = string.Empty;
            txtStokMiktari.Text = string.Empty;
            txtUrunAdi.Text = string.Empty;
            txtUrunFiyati.Text = string.Empty;
            cbDurum.Checked = false;
            rtbUrunAcıklaması.Text = string.Empty;
            lblId.Text = "0";
            lblEklemeTarihi.Text = string.Empty;
        }
        private void UrunYönetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        private void cbDurum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text)) //Veritabanında not null olarak işaretli tüm sütunlar için bu şekilde boş geçilemez kontrolü yaptırmak gerekir
            {
                try
                {
                    var sonuc = manager.Add(
                        new Urun
                        {
                            UrunAdi = txtUrunAdi.Text,
                            UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                            Aciklama = rtbUrunAcıklaması.Text,
                            Aktif = cbDurum.Checked,
                            EklenmeTarihi = DateTime.Now,
                            Iskonto=int.Parse(txtIskonto.Text),
                            Kdv = int.Parse(txtKDV.Text),
                            StokMiktari = int.Parse(txtStokMiktari.Text),
                            ToptanFiyat = decimal.Parse(txtUrunFiyati.Text),
                           KategoriId = int.Parse(cbUrunKategorisi.SelectedValue.ToString()),
                            MarkaId = int.Parse(cbUrunMarkası.SelectedValue.ToString())
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
                    MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi! Lütfen Tüm Alanları Doldurup Tekrar Deneyiniz!");
                }
            }
            else MessageBox.Show("Ürün Fiyatı Boş Geçilemez!");
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text)) //Veritabanında not null olarak işaretli tüm sütunlar için bu şekilde boş geçilemez kontrolü yaptırmak gerekir
            {
                try
                {
                    int urunId = Convert.ToInt32(lblId.Text);
                    if (urunId > 0)
                    {
                        var sonuc = manager.Update(
                        new Urun
                        {
                            Id = urunId,
                            UrunAdi = txtUrunAdi.Text,
                            UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                            Aciklama = rtbUrunAcıklaması.Text,
                            Aktif = cbDurum.Checked,
                            EklenmeTarihi = DateTime.Now,
                            Iskonto = int.Parse(txtIskonto.Text),
                            Kdv = int.Parse(txtKDV.Text),
                            StokMiktari = int.Parse(txtStokMiktari.Text),
                            ToptanFiyat = decimal.Parse(txtUrunFiyati.Text),
                            KategoriId = int.Parse(cbUrunKategorisi.SelectedValue.ToString()),
                            MarkaId = int.Parse(cbUrunMarkası.SelectedValue.ToString())
                        }
                        );
                        if (sonuc > 0)
                        {
                            Temizle();
                            Yukle();
                            MessageBox.Show("Kayıt Güncellendi!");
                        }
                    }
                    else MessageBox.Show("Listeden Bir Ürün Seçiniz!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi! Lütfen Tüm Alanları Doldurup Tekrar Deneyiniz!");
                }
            }
            else MessageBox.Show("Ürün Fiyatı Boş Geçilemez!");
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

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
                int urunId = Convert.ToInt32(lblId.Text);
                if (urunId > 0)
                {
                    var urun = manager.Get(urunId);
                    if (urun != null)
                    {
                        txtIskonto.Text = urun.Iskonto.ToString();
                        txtKDV.Text = urun.Kdv.ToString();
                        txtStokMiktari.Text = urun.StokMiktari.ToString();
                        txtUrunAdi.Text = urun.UrunAdi;
                        txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                        rtbUrunAcıklaması.Text = urun.Aciklama;
                        cbDurum.Checked = urun.Aktif;
                        lblEklemeTarihi.Text = urun.EklenmeTarihi.ToString();
                        cbUrunKategorisi.SelectedValue = urun.KategoriId;
                        cbUrunMarkası.SelectedValue = urun.MarkaId;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Atanırken Hata Oluştu!");
            }
        }
    }
}
