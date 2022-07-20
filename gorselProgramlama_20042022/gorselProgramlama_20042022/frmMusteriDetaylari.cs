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
    public partial class frmMusteriDetaylari : Form
    {
        DataSet1TableAdapters.MüşteriDetaylarıTableAdapter taMusteriDetaylari = new DataSet1TableAdapters.MüşteriDetaylarıTableAdapter();
        DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();

        public frmMusteriDetaylari()
        {
            InitializeComponent();
        }

        private void frmMusteriDetaylari_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taMusteriDetaylari.GetMusterilerinDetaylari();
            cbMusteriler.DataSource = taMusteriler.GetMusteriler();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taMusteriDetaylari.GetMusteriDetaylari(Convert.ToInt16(cbMusteriler.SelectedValue.ToString()));

        }

        private void btnTümKayitlar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taMusteriDetaylari.GetMusterilerinDetaylari();
        }
    }
}
