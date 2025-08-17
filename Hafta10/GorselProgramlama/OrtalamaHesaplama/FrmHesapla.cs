using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplama
{
    public partial class FrmHesapla: Form
    {
        public FrmHesapla()
        {
            InitializeComponent();
        }

       
        private void radioButtonAnaEkran_CheckedChanged(object sender, EventArgs e)
        {
              /*FrmAna formAna = new FrmAna(); //Ana form ekranımızı çağırdık.
              formAna.Show(); //Ana formu göster
              this.Hide(); //Aktif formu gizle*/
        }

        private void FrmHesapla_Load(object sender, EventArgs e)
        {
            textBoxSonuc.Visible = false; //textBoxSonuc nesnesi görünmez olsun.
        }

        double ortalama;
        int vize, final;

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            vize = (Convert.ToInt32((textBoxVize.Text))); //vize notu hesapla
            final= (Convert.ToInt32((textBoxFinal.Text)));//final notu hesapla
            ortalama = Convert.ToDouble(vize*0.3 + final*0.6);//ortalama  hesapla
            textBoxSonuc.Visible = true;//textBoxSonuc görünür yap
            textBoxSonuc.Text = ortalama.ToString(); 
            if (ortalama>=50)
            {
                MessageBox.Show("Dersi Geçtiniz");
            }
            else
            {
                MessageBox.Show("Dersten Kaldınız");
            }

        }
    }
}
