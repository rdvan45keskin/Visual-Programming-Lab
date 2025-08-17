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
    public partial class FrmAna: Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        
        private void radioButtonWeb_CheckedChanged(object sender, EventArgs e)
        {
            FrmHesapla frmHesapla = new FrmHesapla(); //Diğer form ekranını çağırdık.
            frmHesapla.Show(); //Hesaplama formunu göster
            this.Hide(); //Aktif ekranı gizle
        }

        private void radioButtonVeri_CheckedChanged(object sender, EventArgs e)
        {
            FrmHesapla frmHesapla = new FrmHesapla(); //Diğer form ekranını çağırdık.
            frmHesapla.Show();//Hesaplama formunu göster
            this.Hide(); //Aktif ekranı gizle
        }

        private void radioButtonNesne_CheckedChanged(object sender, EventArgs e)
        {
            FrmHesapla frmHesapla = new FrmHesapla(); //Diğer form ekranını çağırdık.
            frmHesapla.Show();//Hesaplama formunu göster
            this.Hide(); //Aktif ekranı gizle
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {

        }
    }
}
