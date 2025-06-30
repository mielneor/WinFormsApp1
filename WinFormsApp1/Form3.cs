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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LGP6AUH1;Initial Catalog=4 variant;Integrated Security=True");
            string Sql = $"select fio from [dbo].[Пользователи] where login = '{DataSend.text}'";
            SqlCommand scmd = new SqlCommand(Sql, con);
            con.Open();
            SqlDataReader sur = scmd.ExecuteReader();
            while (sur.Read())

            {
                string fio = sur["fio"].ToString();
                label1.Text = fio;

            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
