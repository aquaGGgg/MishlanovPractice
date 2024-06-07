using System;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить логику, которая будет выполняться при изменении текста в поле txtUsername.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка имени пользователя и пароля
            if (username == "admin" && password == "admin")
            {
                // Если данные верны, открывается форму для добавления заявки
                Interface adminInterface = new Interface();
                adminInterface.Show();
                this.Hide();
            }
            else if (username == "user" && password == "user")
            {
                // Если данные верны, открывается форму для отслеживания заказов
                UserTrackingForm userTrackingForm = new UserTrackingForm();
                userTrackingForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
