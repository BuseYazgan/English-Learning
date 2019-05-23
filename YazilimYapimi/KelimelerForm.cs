using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimi
{
    public partial class KelimelerForm : MetroFramework.Forms.MetroForm
    {
        public KelimelerForm()
        {
            InitializeComponent();
        }
        KelimelerEntities kelimeler = new KelimelerEntities();
        //textboxların temizlenmesini sağlayan metod.
        public void Clear()
        {
            txtID.Text = string.Empty;
            txtKelime.Text = string.Empty;
            txtTur.Text = string.Empty;
            txtTurkcesi.Text = string.Empty;
            txtOrnekCumle.Text = string.Empty;
        }
        //Entity Framework ile veritabanından aldığımız verileri metroGride dolduruyoruz.
        void Doldur()
        {
            metroGrid1.DataSource = kelimeler.Kelime.ToList();
        }
        //Veritabanına kelime ekliyoruz
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Kelime kelime = new Kelime();
            kelime.Word = txtKelime.Text;
            kelime.TurkceKarsiligi = txtTurkcesi.Text;
            kelime.Type = txtTur.Text;
            kelime.OrnekCumle = txtOrnekCumle.Text;
            kelimeler.Kelime.Add(kelime);
            kelimeler.SaveChanges();
            Doldur();
            MessageBox.Show("Kelime eklendi.");
            Clear();
        }
        //Veritabanındaki kelimlerin silinmesini sağlıyor.
        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(txtID.Text);
            var silinecekKelime = kelimeler.Kelime.Where(w => w.ID == silinecek).FirstOrDefault();
            kelimeler.Kelime.Remove(silinecekKelime);
            kelimeler.SaveChanges();
            Doldur();
            Clear();
        }
        // Veri tabanındaki kelime bilgilerinin güncellenmesini sağlıyor.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {   int guncelle = Convert.ToInt32(txtID.Text);
            var guncellenecekKelime = kelimeler.Kelime.Where(w => w.ID == guncelle).FirstOrDefault();
            guncellenecekKelime.Word = txtKelime.Text;
            guncellenecekKelime.TurkceKarsiligi = txtTurkcesi.Text;
            guncellenecekKelime.Type = txtTur.Text;
            guncellenecekKelime.OrnekCumle = txtOrnekCumle.Text;
            kelimeler.SaveChanges();
            Doldur();
            MessageBox.Show("Kelime güncellendi.");
            Clear();
        }

        private void KelimelerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kelimelerDataSet.Kelime' table. You can move, or remove it, as needed.
            this.kelimeTableAdapter.Fill(this.kelimelerDataSet.Kelime);

        }
        //Anaforma geri dönmeyi sağlayan buton
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm form = new AnaForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
