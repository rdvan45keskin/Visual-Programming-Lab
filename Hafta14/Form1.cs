using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] isimler = { "Süha", "Rıdvan", "Asiye", "Yağmur", "Nagihan", "Cansevi" };
            foreach (string s in isimler)
            {
                listBox1.Items.Add(s);
            }
        }

        private void btnMonthClick_Click(object sender, EventArgs e)
        {
            string[] aylar = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık" };

            int i = Convert.ToInt32(tbxMonth.Text);

            if (i > 0 && i <= 12)
            {
                lbxMonth.Items.Add(aylar[i - 1]);
            }
            else
            {
                MessageBox.Show("Lütfen 1 ile 12 arasında bir değer girin");
                tbxMonth.Text = "";
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[3];
            dizi[0] = "Didem";
            dizi[1] = "Ipek";
            dizi[2] = "Özlem";

            foreach (string s in dizi)
            {
                lbxIsım.Items.Add(s);
            }

            Array.Resize(ref dizi, 4);

            dizi[3] = "Ebru";

            foreach (string s in dizi)
            {
                lbxIsım2.Items.Add(s);
            }
        }

        private void btnRandomCLick_Click(object sender, EventArgs e)
        {
            lbxRandom1.Items.Clear();
            lbxRandom2.Items.Clear();

            int[] sayi = new int[15];
            int[] kup = new int[15];

            Random random = new Random();

            for (int i = 0; i < sayi.Length; i++)
            {
                sayi[i] = random.Next(1,10);
                kup[i] = sayi[i]*sayi[i]*sayi[i];
            }

            foreach (int sayilar in sayi)
            {
                lbxRandom1.Items.Add(sayilar);
            }

            foreach (int kupler in kup)
            {
                lbxRandom2.Items.Add(kupler);
            }
        }
    }
}