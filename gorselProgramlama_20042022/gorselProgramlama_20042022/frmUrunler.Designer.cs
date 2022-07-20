
namespace gorselProgramlama_20042022
{
    partial class frmUrunler
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
            this.btnUrunAlis = new System.Windows.Forms.Button();
            this.btnUrunOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatisRaporlari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSatisRaporlari);
            this.panel1.Controls.Add(this.btnUrunAlis);
            this.panel1.Controls.Add(this.btnUrunOlustur);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 458);
            this.panel1.TabIndex = 0;
            // 
            // btnUrunAlis
            // 
            this.btnUrunAlis.Location = new System.Drawing.Point(12, 67);
            this.btnUrunAlis.Name = "btnUrunAlis";
            this.btnUrunAlis.Size = new System.Drawing.Size(224, 43);
            this.btnUrunAlis.TabIndex = 1;
            this.btnUrunAlis.Text = "Ürün Alış";
            this.btnUrunAlis.UseVisualStyleBackColor = true;
            this.btnUrunAlis.Click += new System.EventHandler(this.btnUrunAlis_Click);
            // 
            // btnUrunOlustur
            // 
            this.btnUrunOlustur.Location = new System.Drawing.Point(12, 12);
            this.btnUrunOlustur.Name = "btnUrunOlustur";
            this.btnUrunOlustur.Size = new System.Drawing.Size(224, 43);
            this.btnUrunOlustur.TabIndex = 0;
            this.btnUrunOlustur.Text = "Yeni Ürün Oluştur";
            this.btnUrunOlustur.UseVisualStyleBackColor = true;
            this.btnUrunOlustur.Click += new System.EventHandler(this.btnUrunOlustur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(242, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 458);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSatisRaporlari
            // 
            this.btnSatisRaporlari.Location = new System.Drawing.Point(12, 121);
            this.btnSatisRaporlari.Name = "btnSatisRaporlari";
            this.btnSatisRaporlari.Size = new System.Drawing.Size(224, 43);
            this.btnSatisRaporlari.TabIndex = 2;
            this.btnSatisRaporlari.Text = "Satış Raporları";
            this.btnSatisRaporlari.UseVisualStyleBackColor = true;
            this.btnSatisRaporlari.Click += new System.EventHandler(this.btnSatisRaporlari_Click);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmUrunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunOlustur;
        private System.Windows.Forms.Button btnUrunAlis;
        private System.Windows.Forms.Button btnSatisRaporlari;
    }
}