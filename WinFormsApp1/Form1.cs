using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LGP6AUH1;Initial Catalog=4 variant;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select login, password from [dbo.][Пользователь] where login = @Login and password = @Pass", con);
            command.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
            command.ExecuteNonQuery();
            DataSend.text = textBox1.Text;
            con.Close();
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

    }
}

