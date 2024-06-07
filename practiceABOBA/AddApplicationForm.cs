using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiceDeskApp
{
    public partial class AddApplicationForm : Form
    {
        private static string connectionString = "Data Source=applications.db;Version=3;";

        public AddApplicationForm()
        {
            InitializeComponent();
            InitializeStatusComboBox();
        }

        private void InitializeStatusComboBox()
        {
            cmbStatus.Items.AddRange(new object[]
            {
                "Новая Заявка",
                "В Процессе Ремонта",
                "Ожидание Запчастей",
                "Готова к Выдаче",
                "Завершена"
            });
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddApplication(txtTypeOfEquipment.Text, txtModel.Text, txtDescription.Text, txtLastName.Text, txtFirstName.Text, txtMiddleName.Text, txtPhone.Text, (ApplicationStatus)cmbStatus.SelectedIndex);
                MessageBox.Show("Заявка успешно добавлена!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddApplication(txtTypeOfEquipment.Text, txtModel.Text, txtDescription.Text, txtLastName.Text, txtFirstName.Text, txtMiddleName.Text, txtPhone.Text, (ApplicationStatus)cmbStatus.SelectedIndex);
                MessageBox.Show("Заявка успешно добавлена!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.");
            }
        }

        private bool ValidateInput()
        {
            // Проверка валидности данных
            if (string.IsNullOrWhiteSpace(txtTypeOfEquipment.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbStatus.SelectedIndex == -1)
            {
                return false;
            }

            if (!ValidateCyrillicAndDash(txtLastName.Text) ||
                !ValidateCyrillicAndDash(txtFirstName.Text) ||
                !ValidateCyrillicAndDash(txtMiddleName.Text))
            {
                return false;
            }

            if (!ValidatePhoneNumber(txtPhone.Text))
            {
                return false;
            }

            return true;
        }

        private static void AddApplication(string typeOfEquipment, string model, string description, string lastName, string firstName, string middleName, string phone, ApplicationStatus status)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Applications (DateAdded, TypeOfEquipment, Model, ProblemDescription, ClientLastName, ClientFirstName, ClientMiddleName, PhoneNumber, Status)
                    VALUES (@DateAdded, @TypeOfEquipment, @Model, @ProblemDescription, @ClientLastName, @ClientFirstName, @ClientMiddleName, @PhoneNumber, @Status)";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@DateAdded", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@TypeOfEquipment", typeOfEquipment);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@ProblemDescription", description);
                    command.Parameters.AddWithValue("@ClientLastName", lastName);
                    command.Parameters.AddWithValue("@ClientFirstName", firstName);
                    command.Parameters.AddWithValue("@ClientMiddleName", middleName);
                    command.Parameters.AddWithValue("@PhoneNumber", phone);
                    command.Parameters.AddWithValue("@Status", (int)status);

                    command.ExecuteNonQuery();
                }
            }
        }

        static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        static bool ValidateCyrillicAndDash(string input)
        {
            string pattern = @"^[а-яА-ЯЁё\-]+$";
            return Regex.IsMatch(input, pattern);
        }

        private void lblTypeOfEquipment_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
