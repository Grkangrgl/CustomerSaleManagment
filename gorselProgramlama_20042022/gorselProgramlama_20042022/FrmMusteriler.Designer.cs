
namespace gorselProgramlama_20042022
{
    partial class FrmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.OdemeAl = new System.Windows.Forms.Button();
            this.BorcEkle = new System.Windows.Forms.Button();
            this.MusteriSil = new System.Windows.Forms.Button();
            this.Duzenle = new System.Windows.Forms.Button();
            this.MusteriKayıt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OdemeAl);
            this.panel1.Controls.Add(this.BorcEkle);
            this.panel1.Controls.Add(this.MusteriSil);
            this.panel1.Controls.Add(this.Duzenle);
            this.panel1.Controls.Add(this.MusteriKayıt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // OdemeAl
            // 
            this.OdemeAl.Location = new System.Drawing.Point(12, 224);
            this.OdemeAl.Name = "OdemeAl";
            this.OdemeAl.Size = new System.Drawing.Size(181, 43);
            this.OdemeAl.TabIndex = 4;
            this.OdemeAl.Text = "Ödeme Al";
            this.OdemeAl.UseVisualStyleBackColor = true;
            this.OdemeAl.Click += new System.EventHandler(this.OdemeAl_Click);
            // 
            // BorcEkle
            // 
            this.BorcEkle.Location = new System.Drawing.Point(12, 175);
            this.BorcEkle.Name = "BorcEkle";
            this.BorcEkle.Size = new System.Drawing.Size(181, 43);
            this.BorcEkle.TabIndex = 3;
            this.BorcEkle.Text = "Borç Ekle";
            this.BorcEkle.UseVisualStyleBackColor = true;
            this.BorcEkle.Click += new System.EventHandler(this.BorcEkle_Click);
            // 
            // MusteriSil
            // 
            this.MusteriSil.Location = new System.Drawing.Point(12, 126);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(181, 43);
            this.MusteriSil.TabIndex = 2;
            this.MusteriSil.Text = "Sil";
            this.MusteriSil.UseVisualStyleBackColor = true;
            this.MusteriSil.Click += new System.EventHandler(this.MusteriSil_Click);
            // 
            // Duzenle
            // 
            this.Duzenle.Location = new System.Drawing.Point(11, 77);
            this.Duzenle.Name = "Duzenle";
            this.Duzenle.Size = new System.Drawing.Size(181, 43);
            this.Duzenle.TabIndex = 1;
            this.Duzenle.Text = "Düzenle";
            this.Duzenle.UseVisualStyleBackColor = true;
            this.Duzenle.Click += new System.EventHandler(this.Duzenle_Click);
            // 
            // MusteriKayıt
            // 
            this.MusteriKayıt.Location = new System.Drawing.Point(12, 28);
            this.MusteriKayıt.Name = "MusteriKayıt";
            this.MusteriKayıt.Size = new System.Drawing.Size(181, 43);
            this.MusteriKayıt.TabIndex = 0;
            this.MusteriKayıt.Text = "Yeni Müşteri Kaydet";
            this.MusteriKayıt.UseVisualStyleBackColor = true;
            this.MusteriKayıt.Click += new System.EventHandler(this.MusteriKayıt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(200, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Müşteri Detay Raporu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OdemeAl;
        private System.Windows.Forms.Button BorcEkle;
        private System.Windows.Forms.Button MusteriSil;
        private System.Windows.Forms.Button Duzenle;
        private System.Windows.Forms.Button MusteriKayıt;
        private System.Windows.Forms.Button button1;
    }
}