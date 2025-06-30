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
            textBox2.PasswordChar = '*';       // Символ для отображения
            textBox2.UseSystemPasswordChar = true;

            // Настройка чекбокса
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text;

            // Проверка заполнения полей
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Показать пароль
                textBox2.PasswordChar = '\0'; // Убрать символ замены
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Скрыть пароль";
            }
            else
            {
                // Скрыть пароль
                textBox2.PasswordChar = '●';
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Показать пароль";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}

