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
    public partial class MarkaYönetimi : Form
    {
        public MarkaYönetimi()
        {
            InitializeComponent();
        }
        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
        }

        private void MarkaYönetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Temizle()
        {
            txtMarkaAciklamasi.Text = string.Empty;
            txtMarkaAdi.Text = string.Empty;
            cbDurum.Checked = false;
            lblId.Text = "0";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int İslemSonucu = manager.Add(
                new Marka
                {
                    MarkaAdi = txtMarkaAdi.Text,
                    Aciklamasi = txtMarkaAciklamasi.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now
                }
                );
            if (İslemSonucu > 0)
            {
                Temizle();
                Yukle();
                MessageBox.Show("Kayıt Eklendi!");
            }
            else MessageBox.Show("Kayıt Eklenemedi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            if (id > 0)
            {
                int islemSonucu = manager.Update(
                    new Marka
                    {
                        Id = id,
                        MarkaAdi = txtMarkaAdi.Text,
                        Aciklamasi = txtMarkaAciklamasi.Text,
                        Aktif = cbDurum.Checked,
                        EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text)
                    }
                    );
                if (islemSonucu > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi!");
                }
                else MessageBox.Show("Kayıt Güncellenemedi!");
            }
            else MessageBox.Show("Listeden güncellenecek kaydı seçiniz!");
        }

        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
            txtMarkaAdi.Text = dgvMarkalar.CurrentRow.Cells[1].Value.ToString();
           txtMarkaAciklamasi.Text = dgvMarkalar.CurrentRow.Cells[2].Value.ToString();
            lblEklenmeTarihi.Text = dgvMarkalar.CurrentRow.Cells[3].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(dgvMarkalar.CurrentRow.Cells[4].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                if (MessageBox.Show("Kaydı silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int islemSonucu = manager.Delete(id);
                    if (islemSonucu > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                    else MessageBox.Show("Kayıt Silinemedi!");
                }

            }
            else MessageBox.Show("Listeden silinecek kaydı seçiniz!");
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            KategoriYönetimi kategoriYonetimi = new KategoriYönetimi();
            this.Close();
            kategoriYonetimi.ShowDialog();
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
                this.Close();
                kullaniciYonetimi.ShowDialog();
            }
        }
    }
    }

