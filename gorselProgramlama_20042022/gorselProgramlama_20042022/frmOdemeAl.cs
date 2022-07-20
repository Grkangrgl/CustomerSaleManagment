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
    public partial class frmOdemeAl : Form
    {
        public frmOdemeAl()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
            DataSet1TableAdapters.MüşteriDetaylarıTableAdapter taMusteriDetaylari = new DataSet1TableAdapters.MüşteriDetaylarıTableAdapter();

            taMusteriler.OdemeAl(Convert.ToDecimal(tbTutar.Text), Convert.ToInt16(lblMusteriNo.Text));

            taMusteriDetaylari.DetayEkle(Convert.ToInt16(lblMusteriNo.Text), 0, Convert.ToDecimal(tbTutar.Text), dtpTarih.Value, tbAcıklama.Text);

            this.Close();

        }

        private void frmOdemeAl_Load(object sender, EventArgs e)
        {

        }
    }
}
