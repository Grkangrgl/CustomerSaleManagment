
namespace gorselProgramlama_20042022
{
    partial class frmUrunSatislari
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
            this.btnUrunKayit = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.cbUrunListesi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMusteriler);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUrunKayit);
            this.panel1.Controls.Add(this.btnUrunListele);
            this.panel1.Controls.Add(this.cbUrunListesi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnUrunKayit
            // 
            this.btnUrunKayit.Location = new System.Drawing.Point(467, 13);
            this.btnUrunKayit.Name = "btnUrunKayit";
            this.btnUrunKayit.Size = new System.Drawing.Size(169, 58);
            this.btnUrunKayit.TabIndex = 3;
            this.btnUrunKayit.Text = "Tüm Kayıtlar";
            this.btnUrunKayit.UseVisualStyleBackColor = true;
            this.btnUrunKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(374, 13);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(87, 24);
            this.btnUrunListele.TabIndex = 2;
            this.btnUrunListele.Text = "Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cbUrunListesi
            // 
            this.cbUrunListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunListesi.FormattingEnabled = true;
            this.cbUrunListesi.Location = new System.Drawing.Point(107, 13);
            this.cbUrunListesi.Name = "cbUrunListesi";
            this.cbUrunListesi.Size = new System.Drawing.Size(240, 24);
            this.cbUrunListesi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Seç";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Seç";
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(374, 50);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(87, 24);
            this.btnMusteriListele.TabIndex = 6;
            this.btnMusteriListele.Text = "Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.DisplayMember = "Adı";
            this.cbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(107, 50);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(240, 24);
            this.cbMusteriler.TabIndex = 7;
            this.cbMusteriler.ValueMember = "MüşteriNo";
            // 
            // frmUrunSatislari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmUrunSatislari";
            this.Text = "Satış Raporu";
            this.Load += new System.EventHandler(this.frmUrunSatislari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.ComboBox cbUrunListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunKayit;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMusteriler;
    }
}