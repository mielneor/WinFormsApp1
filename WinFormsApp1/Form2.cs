using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LGP6AUH1;Initial Catalog=4 variant;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Пользователь] (login, password, fio) VALUES (@Log, @Pass, @Fio)", con);
            command.Parameters.Add("@Log", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@Fio", SqlDbType.VarChar).Value = textBox3.Text;
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Новый пользователь добавлен!");
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
