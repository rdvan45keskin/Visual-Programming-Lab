namespace OrtalamaHesaplama
{
    partial class FrmHesapla
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
            this.radioButtonAnaEkran = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVize = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.textBoxSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonAnaEkran
            // 
            this.radioButtonAnaEkran.AutoSize = true;
            this.radioButtonAnaEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonAnaEkran.Location = new System.Drawing.Point(12, 21);
            this.radioButtonAnaEkran.Name = "radioButtonAnaEkran";
            this.radioButtonAnaEkran.Size = new System.Drawing.Size(96, 20);
            this.radioButtonAnaEkran.TabIndex = 0;
            this.radioButtonAnaEkran.TabStop = true;
            this.radioButtonAnaEkran.Text = "Ana Ekran";
            this.radioButtonAnaEkran.UseVisualStyleBackColor = true;
            this.radioButtonAnaEkran.CheckedChanged += new System.EventHandler(this.radioButtonAnaEkran_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vize Notu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Notu:";
            // 
            // textBoxVize
            // 
            this.textBoxVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVize.Location = new System.Drawing.Point(82, 68);
            this.textBoxVize.Name = "textBoxVize";
            this.textBoxVize.Size = new System.Drawing.Size(113, 22);
            this.textBoxVize.TabIndex = 3;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFinal.Location = new System.Drawing.Point(82, 98);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(113, 22);
            this.textBoxFinal.TabIndex = 4;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHesapla.Location = new System.Drawing.Point(82, 136);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(113, 40);
            this.buttonHesapla.TabIndex = 5;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // textBoxSonuc
            // 
            this.textBoxSonuc.Enabled = false;
            this.textBoxSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSonuc.Location = new System.Drawing.Point(82, 193);
            this.textBoxSonuc.Name = "textBoxSonuc";
            this.textBoxSonuc.Size = new System.Drawing.Size(113, 22);
            this.textBoxSonuc.TabIndex = 6;
            // 
            // FrmHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 252);
            this.Controls.Add(this.textBoxSonuc);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxVize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonAnaEkran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHesapla";
            this.Text = "FrmHesapla";
            this.Load += new System.EventHandler(this.FrmHesapla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAnaEkran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVize;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.TextBox textBoxSonuc;
    }
}