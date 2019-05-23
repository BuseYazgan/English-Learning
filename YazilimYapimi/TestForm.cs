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
    public partial class TestForm : MetroFramework.Forms.MetroForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm form = new AnaForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        KelimelerEntities kelimeler = new KelimelerEntities();
        Kelime kelime = new Kelime();
        Tarih tarih = new Tarih();
        public void Tarih()
        {
            int deger = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Ocak == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID =Convert.ToInt32(lblGizlenmisYil.Text),
                Ocak = deger + 1

            });
            int deger_1 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Subat == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Subat = deger_1 + 1

            });
            int deger_2 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Mart == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Mart = deger_2 + 1

            });
            int deger_3 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Nisan == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Nisan = deger_3 + 1

            });
            int deger_4 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Mayis == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Mayis = deger_4 + 1

            });
            int deger_5 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Haziran == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Haziran = deger_5 + 1

            });
            int deger_6 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Temmuz == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Temmuz = deger_6 + 1

            });
            int deger_7 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Agustos == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Agustos = deger_7 + 1

            });
            int deger_8 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Eylül == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Eylül = deger_8 + 1

            });
            int deger_9 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Ekim == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Ekim = deger_9 + 1

            });
            int deger_10 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Kasim == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Kasim = deger_10 + 1

            });
            int deger_11 = Convert.ToInt32(kelimeler.Tarih.Where(p => p.Aralik == Convert.ToInt32(lblGizlenmisAy.Text)
                        ).FirstOrDefault());
            _update.UpdateData(new Tarih

            {
                ayID = Convert.ToInt32(lblGizlenmisYil.Text),
                Aralik = deger_11 + 1

            });

        }
        Update _update = new Update();  
        private void btnCevap_Click(object sender, EventArgs e)
        {
            string guncelle = txtCevap.Text;
            var guncellenecekKelime = kelimeler.Kelime.Where(w => w.TurkceKarsiligi == guncelle).FirstOrDefault();
            if (txtCevap.Text == lblGizlenmisCvp.Text)
            {
                guncellenecekKelime.BilmeSayisi++;
                switch (guncellenecekKelime.BilmeSayisi)
                {
                    case 1:
                        guncellenecekKelime.BilinmeTarihi = DateTime.Now.AddDays(7);
                        break;

                    case 2:
                        guncellenecekKelime.BilinmeTarihi = DateTime.Now.AddMonths(1);
                        break;

                    case 3:
                        guncellenecekKelime.BilinmeTarihi = DateTime.Now.AddMonths(6);
                        break;
                    case 4:
                        lblGizlenmisYil.Text = DateTime.Now.Year.ToString();
                        lblGizlenmisAy.Text = DateTime.Now.Month.ToString();
                        Tarih();
                        break;
                    default:
                        break;
                }


            }

            else
            {
                MessageBox.Show("Bilemedin...");
                guncellenecekKelime.BilinmeTarihi = DateTime.Now.AddDays(1);
                guncellenecekKelime.BilmeSayisi = 0;
            }

            kelimeler.SaveChanges();        
    }

        private void btnYeniKelime_Click(object sender, EventArgs e)
        {
            DateTime sayac = DateTime.Now;
            while (sayac < DateTime.Now.AddSeconds(5))
            {

                var random = kelimeler.Kelime.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
                lblGizlenmisSoru.Text = random.Word;

                if (random.BilmeSayisi == 4)
                {
                    continue;
                }

                else
                {
                    if (DateTime.Now >= random.BilinmeTarihi || random.BilinmeTarihi == null)
                    {
                        lblSoru.Text = lblGizlenmisSoru.Text;
                        lblGizlenmisCvp.Text = random.TurkceKarsiligi;
                        break;
                    }
                }
            }
            }
    }
}
