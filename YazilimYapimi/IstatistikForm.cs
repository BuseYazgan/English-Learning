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
    public partial class IstatistikForm : MetroFramework.Forms.MetroForm
    {
        public IstatistikForm()
        {
            InitializeComponent();
        }
        //Ana forma geri dönmeyi sağlayan buton
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm form = new AnaForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        KelimelerEntities kelimeler = new KelimelerEntities();

        Tarih tarih = new Tarih();
        private void IstatistikForm_Load(object sender, EventArgs e)
        {

            List<Tarih> istatistikGetir()
            {
                using (KelimelerEntities context = new KelimelerEntities())
                {
                    return context.Set<Tarih>().Where(p=>p.ayID==2019).ToList();
                }
            }
            foreach (var sayi in istatistikGetir())
            {
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Ocak));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Subat));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Mart));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Nisan));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Mayis));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Haziran));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Temmuz));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Agustos));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Eylül));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Ekim));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Kasim));
                chart1.Series["Öğrenilmiş Kelime Sayısı"].Points.Add(Convert.ToInt32(sayi.Aralik));
            }
        }

    }
}

      
          
    

