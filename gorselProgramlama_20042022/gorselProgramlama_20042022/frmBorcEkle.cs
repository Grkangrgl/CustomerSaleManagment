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
    public partial class frmBorcEkle : Form
    {
        public frmBorcEkle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*
             * 1.Müşteri detay a kayıt ekle
             * 2. Müşteriler tab. borç alanını arttır
             */

            DataSet1TableAdapters.MüşteriDetaylarıTableAdapter taMusteriDetaylari = new DataSet1TableAdapters.MüşteriDetaylarıTableAdapter();
            DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();


            taMusteriDetaylari.DetayEkle( Convert.ToInt16(lblMusteriNo.Text),
                Convert.ToDecimal(tbTutar.Text), 0, dtpTarih.Value, tbAcıklama.Text);

            taMusteriler.BorçArttır(Convert.ToDecimal(tbTutar.Text), Convert.ToInt16(lblMusteriNo.Text));

            this.Close();


        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbAcıklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMusteriAdi_Click(object sender, EventArgs e)
        {

        }

        private void lblMusteriNo_Click(object sender, EventArgs e)
        {

        }

        private void frmBorcEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
