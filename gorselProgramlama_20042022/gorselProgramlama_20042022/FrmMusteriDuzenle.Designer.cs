
namespace gorselProgramlama_20042022
{
    partial class FrmMusteriDuzenle
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
            this.iptal = new System.Windows.Forms.Button();
            this.MusteriDuzenle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.musterino = new System.Windows.Forms.Label();
            this.Borc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MusteriAdı = new System.Windows.Forms.TextBox();
            this.MusteriSoyadı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(152, 143);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(100, 33);
            this.iptal.TabIndex = 11;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // MusteriDuzenle
            // 
            this.MusteriDuzenle.Location = new System.Drawing.Point(34, 143);
            this.MusteriDuzenle.Name = "MusteriDuzenle";
            this.MusteriDuzenle.Size = new System.Drawing.Size(100, 33);
            this.MusteriDuzenle.TabIndex = 10;
            this.MusteriDuzenle.Text = "Kaydet";
            this.MusteriDuzenle.UseVisualStyleBackColor = true;
            this.MusteriDuzenle.Click += new System.EventHandler(this.MusteriDuzenle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Musteri No";
            // 
            // musterino
            // 
            this.musterino.AutoSize = true;
            this.musterino.Location = new System.Drawing.Point(149, 13);
            this.musterino.Name = "musterino";
            this.musterino.Size = new System.Drawing.Size(46, 17);
            this.musterino.TabIndex = 13;
            this.musterino.Text = "label4";
            // 
            // Borc
            // 
            this.Borc.Location = new System.Drawing.Point(152, 111);
            this.Borc.Name = "Borc";
            this.Borc.Size = new System.Drawing.Size(100, 22);
            this.Borc.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Borç";
            // 
            // MusteriAdı
            // 
            this.MusteriAdı.Location = new System.Drawing.Point(152, 49);
            this.MusteriAdı.Name = "MusteriAdı";
            this.MusteriAdı.Size = new System.Drawing.Size(100, 22);
            this.MusteriAdı.TabIndex = 16;
            // 
            // MusteriSoyadı
            // 
            this.MusteriSoyadı.Location = new System.Drawing.Point(152, 80);
            this.MusteriSoyadı.Name = "MusteriSoyadı";
            this.MusteriSoyadı.Size = new System.Drawing.Size(100, 22);
            this.MusteriSoyadı.TabIndex = 17;
            // 
            // FrmMusteriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.MusteriSoyadı);
            this.Controls.Add(this.MusteriAdı);
            this.Controls.Add(this.Borc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.musterino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.MusteriDuzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button MusteriDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label musterino;
        public System.Windows.Forms.TextBox Borc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox MusteriAdı;
        public System.Windows.Forms.TextBox MusteriSoyadı;
    }
}