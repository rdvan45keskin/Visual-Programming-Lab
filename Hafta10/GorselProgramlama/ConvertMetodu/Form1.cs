using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertMetodu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            int sayi1; double sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            textBox3.Text = (sayi1 + (Convert.ToInt32(sayi2))).ToString();
            textBox4.Text = (Convert.ToDouble(sayi1) + sayi2).ToString();
        }
    }
}
