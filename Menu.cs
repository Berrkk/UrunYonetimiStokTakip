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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnKategoriYonetimi_Click(object sender, EventArgs e)
        {
           KategoriYönetimi kategoriYonetimi = new KategoriYönetimi();
            kategoriYonetimi.ShowDialog();
        }

        private void btnKullanıcıYonetimi_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();
        }

        private void btnMarkaYonetimi_Click(object sender, EventArgs e)
        {
            MarkaYönetimi markaYonetimi = new MarkaYönetimi();
            markaYonetimi.ShowDialog();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.ShowDialog();
        }

        private void btnSiparisYönetimi_Click(object sender, EventArgs e)
        {
            SiparisYonetimi siparisYonetimi = new SiparisYonetimi();
            siparisYonetimi.ShowDialog();
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            UrunYönetimi urunYonetimi = new UrunYönetimi();
            urunYonetimi.ShowDialog();
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }
    }
}
