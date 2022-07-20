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
    public partial class frmUrunSatislari : Form
    {
        DataSet1TableAdapters.SatışlarTableAdapter taSatislar = new DataSet1TableAdapters.SatışlarTableAdapter();
        DataSet1TableAdapters.ÜrünlerTableAdapter taUrunler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
        DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
        
        public frmUrunSatislari()
        {
            InitializeComponent();
        }

        private void frmUrunSatislari_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taSatislar.GetSatislar();

            cbUrunListesi.DisplayMember = "ÜrünAdı";
            cbUrunListesi.ValueMember = "ÜrünNo";
            cbUrunListesi.DataSource = taUrunler.GetUrunler();

            cbMusteriler.DataSource = taMusteriler.GetMusteriler();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taSatislar.GetUrununSatislari(Convert.ToInt32(cbUrunListesi.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taSatislar.GetSatislar();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taSatislar.GetMusteriyeGoreSatislar (Convert.ToInt32(cbMusteriler.SelectedValue.ToString()));
        }
    }
}
