using Npgsql;
using System;
using System.Windows.Forms;

namespace motorist
{
    public partial class AuthForm : Form
    {
        private NpgsqlConnection connection;
        public static bool authSuccessful = false;

        public AuthForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;

            try
            {
                connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=motorist;Username=postgres;Password=1111;");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            string username = loginInput.Text.Trim();
            string password = passInput.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (UserExists(username, password))
                {
                    MessageBox.Show($"Добро пожаловать, {username}!", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    authSuccessful = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при авторизации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UserExists(string username, string password)
        {
            using (var command = new NpgsqlCommand(
                "SELECT count(*) FROM сотрудники WHERE логин = @Username AND пароль = @Password",
                connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            connection?.Close();
            connection?.Dispose();
            base.OnFormClosing(e);
        }
    }
}