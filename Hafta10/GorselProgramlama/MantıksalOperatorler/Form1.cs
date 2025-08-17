using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantıksalOperatorler
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 & 1 = " + (0 & 1));
        }
        private void buttonVEYA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 | 1 = " + (0 | 1));
        }
        private void buttonXOR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 ^ 1 = " + (0 ^ 1));
        }

        private void buttonDEGIL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!0 = " + !false);
        }
    }
}
