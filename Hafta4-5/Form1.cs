using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nicat");
            listBox1.Items.Add("Musa");
            listBox1.Items.Add("Selo");
            listBox1.Items.Add("Indigo");
            listBox1.Items.Add("Musa Sow");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                btnClear.BackColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir eleman seçin");
                btnClear.BackColor = Color.Red;
                return;
            }
            
        }

        private void btnPhoneAdd_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text);
        }

        private void btnNumberRemove_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(maskedTextBox1.Text);
            listBox3.Items.Add(maskedTextBox1.Text);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime StartDate = monthCalendar1.SelectionStart;
            DateTime EndDate = monthCalendar1.SelectionEnd;
            lblBegin.Text = StartDate.ToString();
            lblEnd.Text = EndDate.ToString();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void saklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 100;
            numericUpDown1.Minimum = 0;
            decimal sayi = numericUpDown1.Value;
            listBox4.Items.Add(sayi);
            btnNumericUpDown.BackColor = Color.LightBlue;
        }
    }
}
