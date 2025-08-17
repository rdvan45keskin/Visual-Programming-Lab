namespace OrtalamaHesaplama
{
    partial class FrmAna
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWeb = new System.Windows.Forms.RadioButton();
            this.radioButtonVeri = new System.Windows.Forms.RadioButton();
            this.radioButtonNesne = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DERS SEÇİNİZ";
            // 
            // radioButtonWeb
            // 
            this.radioButtonWeb.AutoSize = true;
            this.radioButtonWeb.Location = new System.Drawing.Point(101, 47);
            this.radioButtonWeb.Name = "radioButtonWeb";
            this.radioButtonWeb.Size = new System.Drawing.Size(48, 17);
            this.radioButtonWeb.TabIndex = 4;
            this.radioButtonWeb.TabStop = true;
            this.radioButtonWeb.Text = "Web";
            this.radioButtonWeb.UseVisualStyleBackColor = true;
            this.radioButtonWeb.CheckedChanged += new System.EventHandler(this.radioButtonWeb_CheckedChanged);
            // 
            // radioButtonVeri
            // 
            this.radioButtonVeri.AutoSize = true;
            this.radioButtonVeri.Location = new System.Drawing.Point(101, 80);
            this.radioButtonVeri.Name = "radioButtonVeri";
            this.radioButtonVeri.Size = new System.Drawing.Size(43, 17);
            this.radioButtonVeri.TabIndex = 5;
            this.radioButtonVeri.TabStop = true;
            this.radioButtonVeri.Text = "Veri";
            this.radioButtonVeri.UseVisualStyleBackColor = true;
            this.radioButtonVeri.CheckedChanged += new System.EventHandler(this.radioButtonVeri_CheckedChanged);
            // 
            // radioButtonNesne
            // 
            this.radioButtonNesne.AutoSize = true;
            this.radioButtonNesne.Location = new System.Drawing.Point(101, 114);
            this.radioButtonNesne.Name = "radioButtonNesne";
            this.radioButtonNesne.Size = new System.Drawing.Size(56, 17);
            this.radioButtonNesne.TabIndex = 6;
            this.radioButtonNesne.TabStop = true;
            this.radioButtonNesne.Text = "Nesne";
            this.radioButtonNesne.UseVisualStyleBackColor = true;
            this.radioButtonNesne.CheckedChanged += new System.EventHandler(this.radioButtonNesne_CheckedChanged);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 153);
            this.Controls.Add(this.radioButtonNesne);
            this.Controls.Add(this.radioButtonVeri);
            this.Controls.Add(this.radioButtonWeb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAna";
            this.Text = "Ortalama Hesaplama";
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWeb;
        private System.Windows.Forms.RadioButton radioButtonVeri;
        private System.Windows.Forms.RadioButton radioButtonNesne;
    }
}

