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
    public partial class FrmMusteriler : Form
    {

        // field alanlar:
        DataSet1TableAdapters.MüşterilerTableAdapter mta = new DataSet1TableAdapters.MüşterilerTableAdapter();
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mta.GetMusteriler(); 
        }

        private void MusteriKayıt_Click(object sender, EventArgs e)
        {
            //Yeni Müşteri kayıt etmek için FrmMusteriEkle form sınıfından bir örnek nesne oluşturalım
            FrmMusteriEkle frmMusteriEkle = new FrmMusteriEkle();

            frmMusteriEkle.ShowDialog();
            //Müşteri eklenipde form kapandığında gridview da yeni durumu göster

            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void Duzenle_Click(object sender, EventArgs e)
        {
            //datagridview1 de aktif satırdan no, ad ve soyad alalım
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            string no = seciliSatir.Cells["MüşteriNo"].Value.ToString();
            string ad = seciliSatir.Cells["Adı"].Value.ToString();
            string soyad = seciliSatir.Cells["Soyadı"].Value.ToString();
            //Mevcut müşteriyi düzenlemek için FrmMusteriDuzenle formunu açalım
            //Düzenlenecek müşterinin numarasını label 4 de adını ve soyadını textbox'larda gösterelim
            //Varsayalım no 1 Gürkan Gargulu

            FrmMusteriDuzenle frmMusteriDuzenle = new FrmMusteriDuzenle();

            frmMusteriDuzenle.musterino.Text = no;
            frmMusteriDuzenle.MusteriAdı.Text = ad;
            frmMusteriDuzenle.MusteriSoyadı.Text = soyad;
            frmMusteriDuzenle.Borc.Text = seciliSatir.Cells["Borç"].Value.ToString();
            frmMusteriDuzenle.ShowDialog();

            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void MusteriSil_Click(object sender, EventArgs e)
        {
            //datagridview daki seçili satırı silelim

            if(MessageBox.Show("Müşteri silinecek emin misin?", "Sil Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {

                DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
                int no = Convert.ToInt32(seciliSatir.Cells["MüşteriNo"].Value);


                mta.MusteriSil(no);
                dataGridView1.DataSource = mta.GetMusteriler();

            }

            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
            }


        }

        private void BorcEkle_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;

            frmBorcEkle f = new frmBorcEkle();

            f.lblMusteriAdi.Text = seciliSatir.Cells["Adı"].Value.ToString() + " " + seciliSatir.Cells["Soyadı"].Value.ToString();

            f.lblMusteriNo.Text = seciliSatir.Cells["MüşteriNo"].Value.ToString();

            f.ShowDialog();
            
            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void OdemeAl_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;

            frmOdemeAl f = new frmOdemeAl();

            f.lblMusteriAdi.Text = seciliSatir.Cells["Adı"].Value.ToString() + " " + seciliSatir.Cells["Soyadı"].Value.ToString();

            f.lblMusteriNo.Text = seciliSatir.Cells["MüşteriNo"].Value.ToString();

            f.ShowDialog();

            dataGridView1.DataSource = mta.GetMusteriler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriDetaylari f = new frmMusteriDetaylari();
            f.ShowDialog();
        }
    }
}
