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
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        //Kelimeler formunun açılmasını sağlayan buton.
        private void btnKelimeler_Click(object sender, EventArgs e)
        {
            KelimelerForm form = new KelimelerForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        //Test formunun açılmasını sağlayan buton.
        private void btnTestEt_Click(object sender, EventArgs e)
        {
            TestForm form = new TestForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        //İstatistik Formunun açılmasını sağlayan buton.
        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            IstatistikForm form = new IstatistikForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
