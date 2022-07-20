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
    public partial class frmUrunler : Form
    {
        public void UrunleriGetir()
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            dataGridView1.DataSource = ta.GetUrunler();
        }

        public frmUrunler()
        {
            InitializeComponent();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void btnUrunOlustur_Click(object sender, EventArgs e)
        {
            frmUrunOlustur f = new frmUrunOlustur();
            f.ShowDialog();
            UrunleriGetir();

        }

        private void btnUrunAlis_Click(object sender, EventArgs e)
        {
            frmUrunAlis f = new frmUrunAlis();

            DataGridViewRow seciliUrun = dataGridView1.CurrentRow;

            f.lblUrunAdı.Text = seciliUrun.Cells["ÜrünAdı"].Value.ToString();
            f.lblUrunNo.Text = seciliUrun.Cells["ÜrünNo"].Value.ToString();

            f.ShowDialog();
            UrunleriGetir();

        }

        private void btnSatisRaporlari_Click(object sender, EventArgs e)
        {
            frmUrunSatislari f = new frmUrunSatislari();
            f.ShowDialog();
        }
    }
}
