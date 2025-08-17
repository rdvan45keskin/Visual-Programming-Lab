using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta15
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("server=RIDVANKESKIN\\SQLEXPRESS;initial catalog=Northwind;integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Employees (FirstName, LastName) VALUES (@FirstName, @LastName)", conn))
            {
                sqlCommand.Parameters.AddWithValue("@FirstName", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", textBox2.Text);

                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Yeni veri eklendi!");
            }
        }
    }
}
