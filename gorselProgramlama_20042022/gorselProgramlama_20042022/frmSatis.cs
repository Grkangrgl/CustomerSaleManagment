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
    public partial class frmSatis : Form
    {
        DataSet1TableAdapters.ÜrünlerTableAdapter taUrunler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
        DataSet1TableAdapters.MüşterilerTableAdapter taMusteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
        DataSet1TableAdapters.MüşteriDetaylarıTableAdapter taMusteriDetaylari = new DataSet1TableAdapters.MüşteriDetaylarıTableAdapter();
        DataSet1TableAdapters.SatışlarTableAdapter taSatislar = new DataSet1TableAdapters.SatışlarTableAdapter();



        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taMusteriler.GetMusteriler();
            dataGridView2.DataSource = taUrunler.GetUrunler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliUrun = dataGridView2.CurrentRow;

            decimal fiyat = Convert.ToDecimal(seciliUrun.Cells["Fiyat"].Value.ToString());
            tbFiyat.Text = (fiyat * Convert.ToInt16(tbAdet.Text)).ToString();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliUrun = dataGridView2.CurrentRow;
            DataGridViewRow seciliMusteri = dataGridView1.CurrentRow;


            //Satışlar

            taSatislar.SatisEkle(Convert.ToInt16(seciliUrun.Cells["ÜrünNo"].Value.ToString()), 
                Convert.ToInt16(seciliMusteri.Cells["MüşteriNo"].Value.ToString()),
               dtpTarih.Value, Convert.ToInt16(tbAdet.Text), 
               Convert.ToDecimal(seciliUrun.Cells["Fiyat"].Value.ToString()));


            //Stok Azalma

            taUrunler.AdetAzalt(Convert.ToInt16(tbAdet.Text), Convert.ToInt16(seciliUrun.Cells["ÜrünNo"].Value.ToString()));


            //Borç Arttır

            taMusteriler.BorçArttır(Convert.ToDecimal(tbFiyat.Text), Convert.ToInt16(seciliMusteri.Cells["MüşteriNo"].Value.ToString()));


            // Müşteri tablosuna detay ekle

            taMusteriDetaylari.DetayEkle(Convert.ToInt16(seciliMusteri.Cells["MüşteriNo"].Value.ToString()), 
                Convert.ToDecimal(tbFiyat.Text), 0, dtpTarih.Value ,tbAcıklama.Text);

            this.Close();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
