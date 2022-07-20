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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }


        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            //Form açıldığında, kategoriler tablosunu gridview1 de gösterelim

            DataSet1TableAdapters.KategorilerTableAdapter kta = new DataSet1TableAdapters.KategorilerTableAdapter();

            dataGridView1.DataSource = kta.GetKategoriler();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KategoriKaydet_Click(object sender, EventArgs e)
        {
            //KategoriAdı textinde yazan kategori adını kategoriler tablosuna kaydedelim

            DataSet1TableAdapters.KategorilerTableAdapter kta = new DataSet1TableAdapters.KategorilerTableAdapter();

            if(string.IsNullOrWhiteSpace(KategoriAdı.Text))    //KategoriAdı.Text.Length == 0
            {
                MessageBox.Show("Boş Bırakma!");
            }

            else
            {
                
                kta.KategoriEkle(KategoriAdı.Text);
                // Kategori ekledik bu değişikliği göster
                dataGridView1.DataSource = kta.GetKategoriler();

            }


        }

        private void KategoriSil_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter kta = new DataSet1TableAdapters.KategorilerTableAdapter();
            int no = int.Parse(KategoriNo.Text);
            kta.KategoriSil(no);
            //Silindikten sonra göster
            dataGridView1.DataSource = kta.GetKategoriler();

        }
    }
}
