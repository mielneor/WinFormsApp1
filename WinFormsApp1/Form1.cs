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

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LGP6AUH1;Initial Catalog=4 variant;Integrated Security=True"))
                {
                    con.Open();

                    // Правильный запрос с COUNT(*)
                    string query = "SELECT COUNT(*) FROM Пользователь WHERE login = @Login AND password = @Pass";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

                        // Получаем количество найденных пользователей
                        int userCount = (int)command.ExecuteScalar();

                        // Проверяем, найден ли хотя бы один пользователь
                        if (userCount > 0)
                        {
                            // Только при успешной проверке открываем Form3
                            DataSend.text = login;
                            Form3 frm = new Form3();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Показываем ошибку при неверных данных
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка подключения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

