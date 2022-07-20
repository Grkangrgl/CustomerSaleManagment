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
    public partial class FrmMusteriDuzenle : Form
    {
        public FrmMusteriDuzenle()
        {
            InitializeComponent();
        }

        private void MusteriDuzenle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşterilerTableAdapter mta = new DataSet1TableAdapters.MüşterilerTableAdapter();

            try
            {
                decimal borc = Convert.ToDecimal(Borc.Text);
                int no = int.Parse(musterino.Text);
                mta.MusteriGuncelle(MusteriAdı.Text, MusteriSoyadı.Text, borc, no);
                this.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
