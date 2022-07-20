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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        private void MusteriAdKayıt_Click(object sender, EventArgs e)
        {
            //kaydet butonu
            DataSet1TableAdapters.MüşterilerTableAdapter mta = new DataSet1TableAdapters.MüşterilerTableAdapter();

            mta.MusteriEkle(MusteriAd.Text, MusteriSoyad.Text);
            //Kaydettikten sonra kapat
            this.Close();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            //iptal butonu
            this.Close();
        }
    }
}
