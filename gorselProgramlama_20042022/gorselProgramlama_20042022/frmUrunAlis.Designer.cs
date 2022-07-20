
namespace gorselProgramlama_20042022
{
    partial class frmUrunAlis
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
            this.lblUrunNo = new System.Windows.Forms.Label();
            this.lblUrunAdı = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlınanAdet = new System.Windows.Forms.TextBox();
            this.btnUrunAlis = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrunNo
            // 
            this.lblUrunNo.AutoSize = true;
            this.lblUrunNo.Location = new System.Drawing.Point(12, 30);
            this.lblUrunNo.Name = "lblUrunNo";
            this.lblUrunNo.Size = new System.Drawing.Size(46, 17);
            this.lblUrunNo.TabIndex = 0;
            this.lblUrunNo.Text = "label1";
            // 
            // lblUrunAdı
            // 
            this.lblUrunAdı.AutoSize = true;
            this.lblUrunAdı.Location = new System.Drawing.Point(121, 30);
            this.lblUrunAdı.Name = "lblUrunAdı";
            this.lblUrunAdı.Size = new System.Drawing.Size(46, 17);
            this.lblUrunAdı.TabIndex = 1;
            this.lblUrunAdı.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet";
            // 
            // tbAlınanAdet
            // 
            this.tbAlınanAdet.Location = new System.Drawing.Point(91, 98);
            this.tbAlınanAdet.Name = "tbAlınanAdet";
            this.tbAlınanAdet.Size = new System.Drawing.Size(145, 22);
            this.tbAlınanAdet.TabIndex = 3;
            // 
            // btnUrunAlis
            // 
            this.btnUrunAlis.Location = new System.Drawing.Point(91, 140);
            this.btnUrunAlis.Name = "btnUrunAlis";
            this.btnUrunAlis.Size = new System.Drawing.Size(63, 45);
            this.btnUrunAlis.TabIndex = 4;
            this.btnUrunAlis.Text = "Ürün Alış";
            this.btnUrunAlis.UseVisualStyleBackColor = true;
            this.btnUrunAlis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(173, 140);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(63, 45);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmUrunAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnUrunAlis);
            this.Controls.Add(this.tbAlınanAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUrunAdı);
            this.Controls.Add(this.lblUrunNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunAlis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Alış";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAlınanAdet;
        private System.Windows.Forms.Button btnUrunAlis;
        private System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.Label lblUrunNo;
        public System.Windows.Forms.Label lblUrunAdı;
    }
}