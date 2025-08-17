using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            checkedListBox1.Items.Add("Soğan");
            comboBox1.Items.Add("ADC");
            comboBox1.Items.Add("XYZ");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.White;
            btnClick.ForeColor = Color.White;
            btnClick.Text = "OK";
            btnClick.Width = 100;
            btnClick.Height = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "OK";
            button1.Width = 300;
            button1.Height = 330;
            button1.Visible = false;
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            checkedListBox1.Items.Add(name);
        }

        private void btnTimeClick_Click(object sender, EventArgs e)
        {
            string longDate = dateTimePicker1.Value.ToLongDateString();
            string shortDate = dateTimePicker1.Value.ToShortDateString();
            string longTime = dateTimePicker1.Value.ToLongTimeString();
            string shortTime = dateTimePicker1.Value.ToShortTimeString();

            chxDate.Items.Add(longDate);
            chxDate.Items.Add(shortDate);
            chxDate.Items.Add(longTime);
            chxDate.Items.Add(shortTime);

            dateTimePicker1.Visible = false;
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            lbl1.Text = lbl2.Text;
            lbl2.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = checkBox3.Checked.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://net.mehmetakif.edu.tr/");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //listBox1.SetSelected(0,true);
            label2.Text = listBox1.Items.Count.ToString();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            //listBox1.SetSelected(0, true);
            label3.Text = listBox1.SelectedIndex.ToString();
        }
        private void btnSelected_Click(object sender, EventArgs e)
        {
            //listBox1.SetSelected(0, true);
            label4.Text = listBox1.SelectedItem.ToString();
        }
    }
}
