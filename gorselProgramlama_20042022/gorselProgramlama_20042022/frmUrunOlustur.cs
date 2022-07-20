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
    public partial class frmUrunOlustur : Form
    {
        public frmUrunOlustur()
        {
            InitializeComponent();
        }

        private void frmUrunOlustur_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
            cbKategori.DisplayMember = "KategoriAdı";
            cbKategori.ValueMember = "KategoriNo";
            cbKategori.DataSource = ta.GetKategoriler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            ta.YeniUrun(tbAdı.Text, Convert.ToInt16(tbFiyat.Text), Convert.ToInt16(tbAdet.Text), Convert.ToInt16(cbKategori.SelectedValue.ToString()));

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
