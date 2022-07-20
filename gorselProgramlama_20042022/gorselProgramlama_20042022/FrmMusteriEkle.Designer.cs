
namespace gorselProgramlama_20042022
{
    partial class FrmMusteriEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MusteriAd = new System.Windows.Forms.TextBox();
            this.MusteriSoyad = new System.Windows.Forms.TextBox();
            this.MusteriAdKayıt = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // MusteriAd
            // 
            this.MusteriAd.Location = new System.Drawing.Point(133, 23);
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.Size = new System.Drawing.Size(100, 22);
            this.MusteriAd.TabIndex = 2;
            // 
            // MusteriSoyad
            // 
            this.MusteriSoyad.Location = new System.Drawing.Point(133, 75);
            this.MusteriSoyad.Name = "MusteriSoyad";
            this.MusteriSoyad.Size = new System.Drawing.Size(100, 22);
            this.MusteriSoyad.TabIndex = 3;
            // 
            // MusteriAdKayıt
            // 
            this.MusteriAdKayıt.Location = new System.Drawing.Point(16, 140);
            this.MusteriAdKayıt.Name = "MusteriAdKayıt";
            this.MusteriAdKayıt.Size = new System.Drawing.Size(100, 33);
            this.MusteriAdKayıt.TabIndex = 4;
            this.MusteriAdKayıt.Text = "Kaydet";
            this.MusteriAdKayıt.UseVisualStyleBackColor = true;
            this.MusteriAdKayıt.Click += new System.EventHandler(this.MusteriAdKayıt_Click);
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(133, 140);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(100, 33);
            this.iptal.TabIndex = 5;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.MusteriAdKayıt);
            this.Controls.Add(this.MusteriSoyad);
            this.Controls.Add(this.MusteriAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MusteriAd;
        private System.Windows.Forms.TextBox MusteriSoyad;
        private System.Windows.Forms.Button MusteriAdKayıt;
        private System.Windows.Forms.Button iptal;
    }
}