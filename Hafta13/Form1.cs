using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 12)
                {
                    lbxGroup1.Items.Add("Bitti");
                    break;
                }
                lbxGroup1.Items.Add((int)i);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txbWord.Text!="")
            {
                lbxWords.Items.Clear();
                string isim = txbWord.Text;
                foreach (char harf in isim)
                {
                    lbxWords.Items.Add(harf);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kelime giriniz: ");
            }
        }
    }
}
