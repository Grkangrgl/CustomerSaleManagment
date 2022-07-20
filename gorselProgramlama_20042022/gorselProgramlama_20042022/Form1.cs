using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgramlama_20042022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             Menüde kategoriler yazısına tıklandığında
            kategoriler tablosunu görmek ve yeni kategori
            FrmKategoriler formunu açalım
             */

            FrmKategoriler frmKategoriler = new FrmKategoriler();
            //frmKategoriler.Show();          //From1 ile FrmKategoriler arasında geçişe izin verir
            frmKategoriler.ShowDialog();      //Form1 ile FrmKategoriler arasında geçişe izin vermez
            
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunler f = new frmUrunler();
            f.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatis f = new frmSatis();

            f.ShowDialog();
        }

        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunSatislari f = new frmUrunSatislari();

            f.ShowDialog();
        }

        private void müşteriDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriDetaylari f = new frmMusteriDetaylari();

            f.ShowDialog();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkında f = new frmHakkında();
            f.ShowDialog();
        }
    }
}
