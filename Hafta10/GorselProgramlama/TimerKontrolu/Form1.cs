using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerKontrolu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Program açıldığı zaman çalışcak kod
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //timer 100 milisaniyede bir çalışıcak
            timer1.Enabled = true; //timer aktif hale getiriliyor.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayanYazi = label1.Text; //label nesnesindeki mevcut yazıyı al
            int adet = kayanYazi.Length; //yazının uzunluğunu al adet değişkenine ata
            string ilkKarakter, sonrasi;

            ilkKarakter = kayanYazi.Substring(0, 1);
            sonrasi = kayanYazi.Substring(1, adet - 1);
            label1.Text = sonrasi + ilkKarakter;
        }
    }
}
