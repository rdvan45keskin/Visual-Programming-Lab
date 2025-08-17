using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tbxName, "Lütfen İsminizi Girin");
            toolTip1.SetToolTip(tbxSurname, "Lütfen Soyadınızı Girin");
            toolTip1.SetToolTip(tbxPhone, "Lütfen Telefon Numarası Girin");
            toolTip1.SetToolTip(tbxEmail, "Lütfen EPostanızı Girin");
            toolTip1.SetToolTip(tbxJob, "Lütfen İşinizi Girin");
            toolTip1.SetToolTip(btnSave, "Kaydetmek İçin Tıklayın");
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnStrech_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            listBox1.Items.Add(progressBar1.Value);
            if (progressBar1.Value >= 100)
            {
                btnIncrease.Enabled = false;
                btnDecrease.Enabled = true;
            }
            else
            {
                btnIncrease.Enabled = true;
                btnDecrease.Enabled = true;
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
            listBox1.Items.Add(progressBar1.Value);
            if (progressBar1.Value <= 0)
            {
                btnDecrease.Enabled = false;
                btnIncrease.Enabled = true;
            }
            else
            {
                btnDecrease.Enabled = true;
                btnIncrease.Enabled = true;
            }
            //btnDecrease.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Step = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string konu = richTextBox1.Text;
            listBox2.Items.Add(konu);
            btnAdd.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tbxSearch.Text);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox2.Cut();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }
    }
}
