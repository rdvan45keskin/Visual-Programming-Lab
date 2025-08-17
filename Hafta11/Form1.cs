using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double X;
        string islem;

        private void Base(string value)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = value;
            }
            else
            {
                textBox1.Text = textBox1.Text + value;
            }
        }
        private void Operations(string value)
        {
            X = Convert.ToDouble(textBox1.Text);
            islem = value;
            textBox1.Clear();
            //textBox1.Text = textBox1.Text + islem;
            textBox1.Text = islem;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Base("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Base("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Base("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Base("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Base("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Base("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Base("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Base("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Base("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Base("0");
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Operations("+");

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            Operations("-");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            Operations("*");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            Operations("/");
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            Operations("%");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void btn_enter_Click(object sender, EventArgs e)
        { 
            double Y = Convert.ToDouble(textBox1.Text.Substring(1,textBox1.Text.Length - 1));

            switch (islem)
            {
                case "+":
                    textBox1.Text = Convert.ToString(X + Y);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(X - Y);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(X * Y);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(X / Y);
                    break;
                case "%":
                    textBox1.Text = Convert.ToString(X % Y);
                    break;
                default:
                    textBox1.Text = "Hatalı Giriş";
                    break;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int a = 10;
            while (a >= 0)
            {
                lbx_list.Items.Add(a);
                a--;
            }
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            do
            {
                username = tbx_Username.Text;
                password = tbx_Password.Text;
            }while (username != "ztyo" && password != "2002");
            MessageBox.Show("Login Success");
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            int tekToplam = 0;
            int ciftToplam = 0;
            cbx_Odd.Items.Clear();
            cbx_Even.Items.Clear();

            tbx_Odd.Text = "";
            tbx_Even.Text = "";

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    cbx_Even.Items.Add(i);
                    tekToplam += i;
                }
                else
                {
                    cbx_Odd.Items.Add(i);
                    ciftToplam += i;
                }
            }
            tbx_Odd.Text = Convert.ToString(tekToplam);
            tbx_Even.Text = Convert.ToString(ciftToplam);
        }
    }
}
