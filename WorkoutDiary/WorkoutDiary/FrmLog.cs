using System;
using System.Data;
using System.Windows.Forms;

namespace WorkoutDiary
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }
            try
            {
                var adapter =
                    new WorkoutDiaryDBDataSetTableAdapters.UsersTableAdapter();
                DataTable users;
                try
                {
                    users = adapter.LoginQuery(login);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки пользователя: " + ex.Message);
                    return;
                }
                if (users.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь не найден.");
                    return;
                }
                DataRow user = users.Rows[0];

                if (password != user["PasswordHash"].ToString())
                {
                    MessageBox.Show("Неверный пароль.");
                    return;
                }

                string role = user["Role"].ToString();
                int userId = Convert.ToInt32(user["Id"]);
             
                if (role == "Athlete")
                {
                    FrmAthlete form = new FrmAthlete(userId);
                    this.Hide();
                    form.FormClosed += (s, args) => this.Show();
                    form.Show();
                }
                else if (role == "Trainer")
                {
                    FrmTrainer form = new FrmTrainer(userId);
                    this.Hide();
                    form.FormClosed += (s, args) => this.Show();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Для этой роли окно пока не настроено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка входа: " + ex.Message);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (FrmRegister form = new FrmRegister())
            {
                form.ShowDialog();
            }
        }
    }
}