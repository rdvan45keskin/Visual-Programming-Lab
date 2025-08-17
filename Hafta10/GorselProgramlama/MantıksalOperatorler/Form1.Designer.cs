namespace MantıksalOperatorler
{
    partial class Form1
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
            this.buttonVE = new System.Windows.Forms.Button();
            this.buttonVEYA = new System.Windows.Forms.Button();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonDEGIL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVE
            // 
            this.buttonVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVE.Location = new System.Drawing.Point(67, 42);
            this.buttonVE.Name = "buttonVE";
            this.buttonVE.Size = new System.Drawing.Size(103, 35);
            this.buttonVE.TabIndex = 0;
            this.buttonVE.Text = "VE";
            this.buttonVE.UseVisualStyleBackColor = true;
            this.buttonVE.Click += new System.EventHandler(this.buttonVE_Click);
            // 
            // buttonVEYA
            // 
            this.buttonVEYA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVEYA.Location = new System.Drawing.Point(67, 83);
            this.buttonVEYA.Name = "buttonVEYA";
            this.buttonVEYA.Size = new System.Drawing.Size(103, 35);
            this.buttonVEYA.TabIndex = 1;
            this.buttonVEYA.Text = "VEYA";
            this.buttonVEYA.UseVisualStyleBackColor = true;
            this.buttonVEYA.Click += new System.EventHandler(this.buttonVEYA_Click);
            // 
            // buttonXOR
            // 
            this.buttonXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonXOR.Location = new System.Drawing.Point(176, 42);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(103, 35);
            this.buttonXOR.TabIndex = 2;
            this.buttonXOR.Text = "XOR";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonDEGIL
            // 
            this.buttonDEGIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDEGIL.Location = new System.Drawing.Point(176, 83);
            this.buttonDEGIL.Name = "buttonDEGIL";
            this.buttonDEGIL.Size = new System.Drawing.Size(103, 35);
            this.buttonDEGIL.TabIndex = 3;
            this.buttonDEGIL.Text = "DEĞİL";
            this.buttonDEGIL.UseVisualStyleBackColor = true;
            this.buttonDEGIL.Click += new System.EventHandler(this.buttonDEGIL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 ve 0 değeri için mantıksal operatör sonuçları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDEGIL);
            this.Controls.Add(this.buttonXOR);
            this.Controls.Add(this.buttonVEYA);
            this.Controls.Add(this.buttonVE);
            this.Name = "Form1";
            this.Text = "Mantıksal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVE;
        private System.Windows.Forms.Button buttonVEYA;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.Button buttonDEGIL;
        private System.Windows.Forms.Label label1;
    }
}

