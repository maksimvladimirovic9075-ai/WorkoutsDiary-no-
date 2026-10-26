using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutDiary
{
    public partial class FrmRegister : Form
    {
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }
        public FrmRegister()
        {
            InitializeComponent();
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.workoutDiaryDBDataSet.Users);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            if (name == "" || login == "" ||
                password == "" || confirm == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов.");
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }
            try
            {
                var adapter =
                    new WorkoutDiaryDBDataSetTableAdapters.UsersTableAdapter();

                DataTable users = adapter.LoginQuery(login);

                if (users.Rows.Count > 0)
                {
                    MessageBox.Show("Этот логин уже занят.");
                    return;
                }
                adapter.RegisterUser(login, password, name, "Athlete");

                MessageBox.Show("Регистрация прошла успешно!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка регистрации");
            }
        }
        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {

        }
        private void txtPassword_Click(object sender, EventArgs e)
        {

        }
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
