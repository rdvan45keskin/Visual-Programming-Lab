using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arttırma_Azaltma
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi,sayi2;
        
        //Önden++
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true && textBoxSayi1.Text!="")
            {
                sayi = Convert.ToInt32(textBoxSayi1.Text);
                textBoxSonuc1.Text = (++sayi).ToString();
            }
        }

        //Arkadan++
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && textBoxSayi1.Text != "")
            {
                sayi = Convert.ToInt32(textBoxSayi1.Text);
                textBoxSonuc1.Text = (sayi++).ToString();
            }
        }

        //Önden-- 
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true && textBoxSayi2.Text != "")
            {
                sayi2 = Convert.ToInt32(textBoxSayi2.Text);
                textBoxSonuc2.Text = (--sayi2).ToString();
            }
        }

        //Arkadan--
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true && textBoxSayi2.Text != "")
            {
                sayi2 = Convert.ToInt32(textBoxSayi2.Text);
                textBoxSonuc2.Text = (sayi2--).ToString();
            }
        }

        //-= Operatörü
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true && textBoxSayi2.Text != "")
            {
                sayi = Convert.ToInt32(textBoxSayi1.Text);
                sayi2 = Convert.ToInt32(textBoxSayi2.Text);

                sayi -= sayi2;
                textBox6.Text = sayi.ToString();
            }
        }

        //+= Operatörü
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true && textBoxSayi1.Text!="")
            {
                sayi = Convert.ToInt32(textBoxSayi1.Text);
                sayi2= Convert.ToInt32(textBoxSayi2.Text);

                sayi += sayi2;
                textBox3.Text = sayi.ToString();
            }
        }
    }
}
